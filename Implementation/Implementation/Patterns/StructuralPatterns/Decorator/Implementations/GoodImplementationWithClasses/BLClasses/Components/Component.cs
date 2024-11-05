using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClasses.BLClasses.Components
{
    internal abstract class Component : IComponent
    {
        public abstract string Operation();
    }
}
