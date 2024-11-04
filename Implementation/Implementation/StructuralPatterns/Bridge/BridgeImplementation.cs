using Implementation.Structural_Patterns.Bridge.BL_Classes.Abstractions;
using Implementation.Structural_Patterns.Bridge.BL_Classes.Clients;
using Implementation.Structural_Patterns.Bridge.BL_Classes.Implementations;

namespace Implementation.Structural_Patterns.Bridge
{
    internal class BridgeImplementation
    {
        static void Main(string[] args)
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
