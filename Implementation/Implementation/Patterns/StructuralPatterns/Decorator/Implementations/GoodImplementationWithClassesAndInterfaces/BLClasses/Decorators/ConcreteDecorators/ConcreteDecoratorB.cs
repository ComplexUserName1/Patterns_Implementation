using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators.ConcreteDecorators
{
    // Декораторы могут выполнять своё поведение до или после вызова обёрнутого
    // объекта.
    internal class ConcreteDecoratorB : DecoratorWithInterface
    {
        public ConcreteDecoratorB(IComponent comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
