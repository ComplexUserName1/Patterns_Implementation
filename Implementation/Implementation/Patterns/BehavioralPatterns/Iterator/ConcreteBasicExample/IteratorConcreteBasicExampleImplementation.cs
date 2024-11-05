using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Clients;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteAggregators;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample
{
    internal class IteratorConcreteBasicExampleImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}
