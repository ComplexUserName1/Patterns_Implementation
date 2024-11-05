using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.Clients;
using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteVisitors;
using Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample
{
    internal class BasicExampleImplementation
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}
