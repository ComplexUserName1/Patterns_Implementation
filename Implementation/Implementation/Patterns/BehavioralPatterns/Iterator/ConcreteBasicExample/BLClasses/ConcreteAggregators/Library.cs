using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteIterators;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.Models;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Aggregates;
using Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.Interfaces.Iterators;

namespace Implementation.BehavioralPatterns.Iterator.ConcreteBasicExample.BLClasses.ConcreteAggregators
{
    internal class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Война и мир"},
            new Book {Name="Отцы и дети"},
            new Book {Name="Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
