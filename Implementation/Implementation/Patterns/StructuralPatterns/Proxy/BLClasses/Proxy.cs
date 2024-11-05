using Implementation.StructuralPatterns.Proxy.BLClasses.Subjects;
using Implementation.StructuralPatterns.Proxy.Interfaces;

namespace Implementation.StructuralPatterns.Proxy.BLClasses
{
    // Интерфейс Заместителя идентичен интерфейсу Реального Субъекта.
    internal class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // Наиболее распространёнными областями применения паттерна Заместитель
        // являются ленивая загрузка, кэширование, контроль доступа, ведение
        // журнала и т.д. Заместитель может выполнить одну из этих задач, а
        // затем, в зависимости от результата, передать выполнение одноимённому
        // методу в связанном объекте класса Реального Субъект.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Некоторые реальные проверки должны проходить здесь.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
