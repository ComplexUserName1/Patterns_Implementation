using Implementation.StructuralPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.StructuralPatterns.Decorator.Helpers
{
    internal class DecoratorImplementationHelper
    {
        public static void ExecuteClient(IClient client, IComponent simple, params IComponent[] decorators)
        {
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // Обёртываем простой компонент в декораторы
            foreach (var decorator in decorators)
            {
                simple = decorator;
            }

            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(simple);
        }
    }
}
