using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteAggregators;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Models;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Iterators;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Clients
{
    internal class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
