using Implementation.BehavioralPatterns.Memento.BLClasses.Caretakers;
using Implementation.BehavioralPatterns.Memento.BLClasses.Originators;

namespace Implementation.BehavioralPatterns.Memento
{
    internal class MementoImplementation
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
        }
    }
}
