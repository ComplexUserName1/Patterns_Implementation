
namespace Implementation.BehavioralPatterns.State.BLClasses.States.ConcreteStates
{
    // Конкретные Состояния реализуют различные модели поведения, связанные с
    // состоянием Контекста.
    internal class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateC());
        }
    }
}
