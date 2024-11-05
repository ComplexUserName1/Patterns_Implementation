using Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Aggregates.ConcreteAggregators;
using Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Aggregates;
using IteratorClass = Implementation.BehavioralPatterns.Iterator.MostBasicExample.BLClasses.Iterators.Iterator;

namespace Implementation.BehavioralPatterns.Iterator.MostBasicExample
{
    internal class MostbasicExampleImplementation
    {
        static void Main(string[] args)
        {
            Aggregate a = new ConcreteAggregate();

            for (int j = 0; j < 10; j++)
            {
                a[j] = j;
            }

            IteratorClass i = a.CreateIterator();

            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine(item);

                item = i.Next();
            }
        }
    }
}
