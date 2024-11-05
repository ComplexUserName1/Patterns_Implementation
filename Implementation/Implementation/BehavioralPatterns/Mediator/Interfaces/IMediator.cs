
namespace Implementation.BehavioralPatterns.Mediator.Interfaces
{
    // Интерфейс Посредника предоставляет метод, используемый компонентами для
    // уведомления посредника о различных событиях. Посредник может реагировать
    // на эти события  и передавать исполнение другим компонентам.
    internal interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
