using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Decorators.ConcreteDecorators
{
    // Конкретные Декораторы вызывают обёрнутый объект и изменяют его результат
    // некоторым образом.
    internal class ConcreteDecoratorC : DecoratorWithClass
    {
        public ConcreteDecoratorC(Component comp) : base(comp)
        {
        }

        // Декораторы могут вызывать родительскую реализацию операции, вместо
        // того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        // расширение классов декораторов.
        public override string Operation()
        {
            return $"ConcreteDecoratorC({base.Operation()})";
        }
    }
}
