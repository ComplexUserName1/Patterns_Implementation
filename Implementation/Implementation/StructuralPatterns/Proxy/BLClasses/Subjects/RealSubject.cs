using Implementation.StructuralPatterns.Proxy.Interfaces;

namespace Implementation.StructuralPatterns.Proxy.BLClasses.Subjects
{
    // Реальный Субъект содержит некоторую базовую бизнес-логику. Как правило,
    // Реальные Субъекты способны выполнять некоторую полезную работу, которая к
    // тому же может быть очень медленной или точной – например, коррекция
    // входных данных. Заместитель может решить эти задачи без каких-либо
    // изменений в коде Реального Субъекта.
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
