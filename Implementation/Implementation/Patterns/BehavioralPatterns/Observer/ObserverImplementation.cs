using Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteObservers;
using Implementation.BehavioralPatterns.Observer.BLClasses.ConcreteSubjects;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Observer
{
    internal class ObserverImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            // Клиентский код.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
