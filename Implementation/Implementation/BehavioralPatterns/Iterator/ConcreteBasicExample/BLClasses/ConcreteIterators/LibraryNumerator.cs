using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Models;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Aggregates;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Iterators;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteIterators
{
    internal class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;
        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }
}
