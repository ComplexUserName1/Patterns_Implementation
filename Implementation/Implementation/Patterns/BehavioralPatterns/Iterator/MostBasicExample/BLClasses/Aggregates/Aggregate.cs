using IteratorClass = Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators.Iterator;

namespace Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Aggregates
{
    //Базовый абстрактный интерфейс агрегатора для переопределения
    internal abstract class Aggregate
    {
        public abstract IteratorClass CreateIterator();
        public abstract int Count { get; protected set; }
        public abstract object this[int index] { get; set; }
    }
}
