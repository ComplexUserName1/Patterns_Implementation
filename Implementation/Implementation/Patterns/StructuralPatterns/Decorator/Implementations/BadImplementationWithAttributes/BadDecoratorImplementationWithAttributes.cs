using Implementation.StartupEntryPoint.Interfaces;
using Implementation.StructuralPatterns.Decorator.BLClasses.Clients;
using Implementation.StructuralPatterns.Decorator.Helpers;
using Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes.BLClasses.Attributes;
using Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes.BLClasses.ConcreteComponents;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Components;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators;
using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes
{
    // P.S. Почему я назвал этот подход плохим? Всё просто.
    // Тут мы используем рефлексию, чтобы динамически модифицировать
    // поведение объекта во время выполнения программы.
    // Я думаю нет смысла писать как много минусов может быть у
    // этого подхода. Рефлексией вообще в целом лучше пользоваться
    // если не осталось никаких других решений, но лучше всё таки
    // побольше подумать)))
    internal class BadDecoratorImplementationWithAttributes : IPatternImplementationStrategy
    {
        public void Run()
        {
            Client client = new Client();

            // Чисто показать что всё в принципе взаимозаменяемо.
            var simple = new ConcreteComponentWithAttributes();

            IComponent decorator = new ConcreteComponentWithAttributes();

            var type = decorator.GetType();

            // Применяем декораторы на основе атрибутов
            foreach (var attribute in type.GetCustomAttributes(typeof(DecoratorAttribute), false))
            {
                var decoratorType = ((DecoratorAttribute)attribute).DecoratorType;
                var decoratorInstance = (DecoratorWithInterface)Activator.CreateInstance(decoratorType, decorator);
                decorator = decoratorInstance;
            }

            ExecuteCustomClient(client, simple, decorator);
        }
        private static void ExecuteCustomClient(Client client, ConcreteComponentWithAttributes simple, IComponent decorator)
            => DecoratorImplementationHelper.ExecuteClient(client, simple, decorator);
    }
}
