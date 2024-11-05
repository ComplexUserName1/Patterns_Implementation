
namespace Implementation.BehavioralPatterns.Observer.Interfaces
{
    internal interface IObserver
    {
        // Получает обновление от издателя
        void Update(ISubject subject);
    }
}
