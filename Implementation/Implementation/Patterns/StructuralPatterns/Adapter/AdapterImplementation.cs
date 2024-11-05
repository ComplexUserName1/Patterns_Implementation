using Implementation.StartupEntryPoint.Interfaces;
using Implementation.Structural_Patterns.Adapter.BL_Classes.Adaptees;
using Implementation.Structural_Patterns.Adapter.BL_Classes.Adapters;
using Implementation.Structural_Patterns.Adapter.Interfaces;

namespace Implementation.Structural_Patterns.Adapter
{
    internal class AdapterImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterClass(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
