using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators.ConcreteDecorators
{
    // Конкретные Декораторы вызывают обёрнутый объект и изменяют его результат
    // некоторым образом.
    internal class ConcreteDecoratorA : DecoratorWithInterface
    {
        public ConcreteDecoratorA(IComponent comp) : base(comp)
        {
        }

        // Декораторы могут вызывать родительскую реализацию операции, вместо
        // того, чтобы вызвать обёрнутый объект напрямую. Такой подход упрощает
        // расширение классов декораторов.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
