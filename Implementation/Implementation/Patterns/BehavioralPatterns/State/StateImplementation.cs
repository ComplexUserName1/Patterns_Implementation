using Implementation.BehavioralPatterns.State.BLClasses.Contexts;
using Implementation.BehavioralPatterns.State.BLClasses.States.ConcreteStates;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.State.BLClasses
{
    internal class StateImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            // Клиентский код.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
            context.Request2();
            context.Request2();
        }
    }
}
