using Implementation.BehavioralPatterns.Mediator.BLClasses.Components.ConcreteComponents;
using Implementation.BehavioralPatterns.Mediator.BLClasses.ConcreteMediators;

namespace Implementation.BehavioralPatterns.Mediator
{
    internal class MediatorImplementation
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
