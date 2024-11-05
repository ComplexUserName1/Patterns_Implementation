
namespace Implementation.BehavioralPatterns.State.BLClasses.States.ConcreteStates
{
    // Конкретные Состояния реализуют различные модели поведения, связанные с
    // состоянием Контекста.
    internal class ConcreteStateC : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateC handles request1.");
            Console.WriteLine("ConcreteStateC wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateA());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateC handles request2.");
            Console.WriteLine("ConcreteStateC wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateB());
        }
    }
}
