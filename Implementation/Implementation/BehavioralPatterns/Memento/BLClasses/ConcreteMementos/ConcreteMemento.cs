using Implementation.BehavioralPatterns.Memento.Interfaces;

namespace Implementation.BehavioralPatterns.Memento.BLClasses.ConcreteMementos
{
    // Конкретный снимок содержит инфраструктуру для хранения состояния
    // Создателя.
    internal class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // Создатель использует этот метод, когда восстанавливает своё
        // состояние.
        public string GetState()
        {
            return this._state;
        }

        // Остальные методы используются Опекуном для отображения метаданных.
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
