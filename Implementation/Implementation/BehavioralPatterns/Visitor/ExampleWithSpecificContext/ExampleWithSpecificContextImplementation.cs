using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.Clients;
using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteVisitors;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext
{
    internal class ExampleWithSpecificContextImplementation
    {
        static void Main(string[] args)
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Ivan", Number = "8912313142" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "wewds22313412", Number = "123123423" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.Read();
        }
    }
}
