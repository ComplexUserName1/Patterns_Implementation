
namespace Implementation.BehavioralPatterns.Memento.Interfaces
{
    // Интерфейс Снимка предоставляет способ извлечения метаданных снимка, таких
    // как дата создания или название. Однако он не раскрывает состояние
    // Создателя.
    internal interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
