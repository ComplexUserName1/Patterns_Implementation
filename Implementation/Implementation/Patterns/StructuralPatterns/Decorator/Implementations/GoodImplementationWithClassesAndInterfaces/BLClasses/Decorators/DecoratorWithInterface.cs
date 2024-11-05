using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators
{
    // Базовый класс Декоратора следует тому же интерфейсу, что и другие
    // компоненты. Основная цель этого класса - определить интерфейс обёртки для
    // всех конкретных декораторов. Реализация кода обёртки по умолчанию может
    // включать в себя  поле для хранения завёрнутого компонента и средства его
    // инициализации.
    internal class DecoratorWithInterface : IComponent
    {
        protected IComponent _component;

        public DecoratorWithInterface(IComponent component)
        {
            _component = component;
        }

        public void SetComponent(IComponent component)
        {
            _component = component;
        }

        // Декоратор делегирует всю работу обёрнутому компоненту.
        public virtual string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
