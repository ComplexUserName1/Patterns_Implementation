using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Decorators.ConcreteDecorators
{
    // Декораторы могут выполнять своё поведение до или после вызова обёрнутого
    // объекта.
    internal class ConcreteDecoratorD : DecoratorWithClass
    {
        public ConcreteDecoratorD(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorD({base.Operation()})";
        }
    }
}
