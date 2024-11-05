using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Models;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Iterators
{
    //Базовый абстрактный интерфейс итератора для переопределения
    internal interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
