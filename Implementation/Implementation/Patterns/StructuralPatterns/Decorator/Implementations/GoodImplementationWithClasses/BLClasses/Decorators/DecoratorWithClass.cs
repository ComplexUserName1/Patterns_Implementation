using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Decorators
{
    // Базовый класс Декоратора следует тому же интерфейсу, что и другие
    // компоненты. Основная цель этого класса - определить интерфейс обёртки для
    // всех конкретных декораторов. Реализация кода обёртки по умолчанию может
    // включать в себя  поле для хранения завёрнутого компонента и средства его
    // инициализации.
    internal class DecoratorWithClass : Component
    {
        protected Component _component;

        public DecoratorWithClass(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        // Декоратор делегирует всю работу обёрнутому компоненту.
        public override string Operation()
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
