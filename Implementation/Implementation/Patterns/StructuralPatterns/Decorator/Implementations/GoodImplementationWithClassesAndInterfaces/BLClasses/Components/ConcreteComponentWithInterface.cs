using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Components
{
    // Конкретные Компоненты предоставляют реализации поведения по умолчанию.
    // Может быть несколько вариаций этих классов.
    internal class ConcreteComponentWithInterface : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponentWithInterface";
        }
    }
}
