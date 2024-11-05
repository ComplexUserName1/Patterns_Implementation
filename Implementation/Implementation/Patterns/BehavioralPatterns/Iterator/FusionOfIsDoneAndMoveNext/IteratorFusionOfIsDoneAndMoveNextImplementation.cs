using Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext.BLClasses.Aggregates.ConcreteAggregators;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Iterator.FusionOfIsDoneAndMoveNext
{
    internal class IteratorFusionOfIsDoneAndMoveNextImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            // Клиентский код может знать или не знать о Конкретном Итераторе
            // или классах Коллекций, в зависимости от уровня косвенности,
            // который вы хотите сохранить в своей программе.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
