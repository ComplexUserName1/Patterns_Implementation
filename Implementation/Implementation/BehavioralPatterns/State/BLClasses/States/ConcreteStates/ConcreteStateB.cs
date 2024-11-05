
namespace Implementation.BehavioralPatterns.State.BLClasses.States.ConcreteStates
{
    // Конкретные Состояния реализуют различные модели поведения, связанные с
    // состоянием Контекста.
    internal class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateC());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.\n");
            this._context.TransitionTo(new ConcreteStateA());
        }
    }
}
