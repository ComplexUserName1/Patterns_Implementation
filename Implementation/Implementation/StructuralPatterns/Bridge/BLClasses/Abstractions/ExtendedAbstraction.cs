using Implementation.Structural_Patterns.Bridge.Interfaces;

namespace Implementation.Structural_Patterns.Bridge.BL_Classes.Abstractions
{
    // Можно расширить Абстракцию без изменения классов Реализации.
    internal class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
