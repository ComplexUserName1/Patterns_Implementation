using Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes.BLClasses.Attributes;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators.ConcreteDecorators;
using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes.BLClasses.ConcreteComponents
{
    [Decorator(typeof(ConcreteDecoratorA))]
    [Decorator(typeof(ConcreteDecoratorB))]
    internal class ConcreteComponentWithAttributes : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponentWithAttributes";
        }
    }
}
