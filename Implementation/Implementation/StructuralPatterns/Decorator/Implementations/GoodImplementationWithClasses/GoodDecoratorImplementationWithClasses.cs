using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components.ConcreteComponents;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Decorators.ConcreteDecorators;
using Implementation.StructuralPatterns.Decorator.BLClasses.Clients;
using Implementation.StructuralPatterns.Decorator.Helpers;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses
{
    // P.S. Вообще можно было бы не усложнять всё и показать самый простой пример
    // паттерна либо с использованием интерфейса, либо с использованием
    // абстрактного класса.
    internal class GoodDecoratorImplementationWithClasses
    {
        static void Main(string[] args)
        {

            Client client = new Client();

            var simple = new ConcreteComponentWithClass();

            // Обратите внимание, что декораторы могут обёртывать не только
            // простые компоненты, но и другие декораторы.
            ConcreteDecoratorC decorator1 = new ConcreteDecoratorC(simple);
            ConcreteDecoratorD decorator2 = new ConcreteDecoratorD(decorator1);

            ExecuteCustomClient(client, simple, decorator1, decorator2);
        }

        private static void ExecuteCustomClient(Client client, ConcreteComponentWithClass simple, ConcreteDecoratorC decorator1, ConcreteDecoratorD decorator2)
            => DecoratorImplementationHelper.ExecuteClient(client, simple, decorator1, decorator2);
    }
}
