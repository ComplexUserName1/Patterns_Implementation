using Implementation.StartupEntryPoint.Interfaces;
using Implementation.Structural_Patterns.Bridge.BL_Classes.Abstractions;
using Implementation.Structural_Patterns.Bridge.BL_Classes.Clients;
using Implementation.Structural_Patterns.Bridge.BL_Classes.Implementations;

namespace Implementation.Structural_Patterns.Bridge
{
    internal class BridgeImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Client client = new Client();

            Abstraction abstraction;
            // Клиентский код должен работать с любой предварительно
            // сконфигурированной комбинацией абстракции и реализации.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
