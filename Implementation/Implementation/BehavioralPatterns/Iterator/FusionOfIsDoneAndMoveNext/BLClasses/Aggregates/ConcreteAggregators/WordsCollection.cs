using Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext.BLClasses.Iterators.ConcreteIterators;
using System.Collections;

namespace Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext.BLClasses.Aggregates.ConcreteAggregators
{
    // Конкретные Коллекции предоставляют один или несколько методов для
    // получения новых экземпляров итератора, совместимых с классом коллекции.
    internal class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
