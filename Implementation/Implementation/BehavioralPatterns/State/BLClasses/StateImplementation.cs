using Implementation.BehavioralPatterns.State.BLClasses.Contexts;
using Implementation.BehavioralPatterns.State.BLClasses.States.ConcreteStates;

namespace Implementation.BehavioralPatterns.State.BLClasses
{
    internal class StateImplementation
    {
        static void Main(string[] args)
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
