using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.Helpers
{
    internal class DecoratorImplementationHelper
    {
        public static void ExecuteClient(IClient client, IComponent simple, params IComponent[] decorators)
        {
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorators.Last());
        }
    }
}
