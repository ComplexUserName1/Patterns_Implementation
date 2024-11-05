using Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Aggregates;

namespace Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators.ConcreteIterators
{
    //Конкретный итератор с логикой обхода
    //Так-же по названию итератора можно в принципе понять суть обхода коллекции(алгоритмы обхода)
    //Это уже будет видно в конкретных примерах.
    internal class ConcreteIterator : Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
