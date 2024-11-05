using System.Collections;

namespace Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext.BLClasses.Aggregates
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }
}
