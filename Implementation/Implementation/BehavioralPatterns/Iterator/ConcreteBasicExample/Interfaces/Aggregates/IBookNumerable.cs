using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Models;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Iterators;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Aggregates
{
    internal interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}
