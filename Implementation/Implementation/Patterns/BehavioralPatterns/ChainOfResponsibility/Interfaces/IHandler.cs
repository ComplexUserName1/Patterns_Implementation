
namespace Implementation.BehavioralPatterns.ChainOfResponsibility.Interfaces
{
    // Интерфейс Обработчика объявляет метод построения цепочки обработчиков. Он
    // также объявляет метод для выполнения запроса.
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
