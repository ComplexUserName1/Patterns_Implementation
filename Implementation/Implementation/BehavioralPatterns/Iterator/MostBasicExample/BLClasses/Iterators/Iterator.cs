
namespace Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators
{
    //Базовый абстрактный интерфейс итератора для переопределения
    internal abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
