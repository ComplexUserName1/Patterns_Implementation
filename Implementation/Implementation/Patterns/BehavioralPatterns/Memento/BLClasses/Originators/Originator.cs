using Implementation.BehavioralPatterns.Memento.BLClasses.ConcreteMementos;
using Implementation.BehavioralPatterns.Memento.Interfaces;

namespace Implementation.BehavioralPatterns.Memento.BLClasses.Originators
{
    // Создатель содержит некоторое важное состояние, которое может со временем
    // меняться. Он также объявляет метод сохранения состояния внутри снимка и
    // метод восстановления состояния из него.
    internal class Originator
    {
        // Для удобства состояние создателя хранится внутри одной переменной.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        // Бизнес-логика Создателя может повлиять на его внутреннее состояние.
        // Поэтому клиент должен выполнить резервное копирование состояния с
        // помощью метода save перед запуском методов бизнес-логики.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Сохраняет текущее состояние внутри снимка.
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Восстанавливает состояние Создателя из объекта снимка.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}
