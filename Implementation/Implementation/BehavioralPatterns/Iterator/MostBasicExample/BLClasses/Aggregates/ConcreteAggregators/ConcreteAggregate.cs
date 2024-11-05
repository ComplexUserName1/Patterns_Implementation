using Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators.ConcreteIterators;
using System.Collections;
using IteratorClass = Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators.Iterator;

namespace Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Aggregates.ConcreteAggregators
{
    //Конкретный агрегатор с конкретной структурой данных для которой мы пишем итератор
    //Так-же по названию агрегатора можно понять что по сути будет храниться в структуре данных(будет видно в конкретных примерах).
    internal class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override IteratorClass CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count
        {
            get { return _items.Count; }
            protected set { }
        }

        public override object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
