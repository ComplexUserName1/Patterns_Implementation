using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Clients;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteAggregators;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample
{
    internal class ConcreteBasicExampleImplementation
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}
