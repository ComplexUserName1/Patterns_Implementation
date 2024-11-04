
namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components.ConcreteComponents
{
    // Конкретные Компоненты предоставляют реализации поведения по умолчанию.
    // Может быть несколько вариаций этих классов.
    internal class ConcreteComponentWithClass : Component
    {
        public override string Operation()
        {
            return "ConcreteComponentWithClass";
        }
    }
}
