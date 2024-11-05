using Implementation.BehavioralPatterns.TemplateMethod.BLClasses.AbstractClass.ConcreteClasses;
using Implementation.BehavioralPatterns.TemplateMethod.BLClasses.Clients;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.TemplateMethod
{
    internal class TemplateMethodImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}
