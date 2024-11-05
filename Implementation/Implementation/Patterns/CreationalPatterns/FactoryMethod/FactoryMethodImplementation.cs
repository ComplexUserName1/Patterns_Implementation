using Implementation.Creational_Patterns.Factory_Method.BL_Classes.Clients;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.Creational_Patterns.Factory_Method
{
    internal class FactoryMethodImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            new Client().Main();
        }
    }
}
