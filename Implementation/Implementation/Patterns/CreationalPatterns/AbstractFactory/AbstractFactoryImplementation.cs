using Implementation.Creational_Patterns.Abstract_Factory.Classes.Clients;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.Creational_Patterns.Abstract_Factory
{
    internal class AbstractFactoryImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            new Client().Main();
        }
    }
}
