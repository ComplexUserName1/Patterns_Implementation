using Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteSubjects;
using Implementation.BehavioralPatterns.Observer.Interfaces;

namespace Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteObservers
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
