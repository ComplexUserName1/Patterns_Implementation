using StateClass = Implementation.BehavioralPatterns.State.BLClasses.States.State;

namespace Implementation.BehavioralPatterns.State.BLClasses.Contexts
{
    // Контекст определяет интерфейс, представляющий интерес для клиентов. Он
    // также хранит ссылку на экземпляр подкласса Состояния, который отображает
    // текущее состояние Контекста.
    internal class Context
    {
        // Ссылка на текущее состояние Контекста.
        private StateClass _state = null;

        public Context(StateClass state)
        {
            this.TransitionTo(state);
        }

        // Контекст позволяет изменять объект Состояния во время выполнения.
        public void TransitionTo(StateClass state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        // Контекст делегирует часть своего поведения текущему объекту
        // Состояния.
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
