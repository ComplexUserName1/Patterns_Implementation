using Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteSubjects;
using Implementation.BehavioralPatterns.Observer.Interfaces;

namespace Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteObservers
{
    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
