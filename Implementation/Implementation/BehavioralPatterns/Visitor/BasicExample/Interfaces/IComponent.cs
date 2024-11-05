
namespace Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces
{
    // Интерфейс Компонента объявляет метод accept, который в качестве аргумента
    // может получать любой объект, реализующий интерфейс посетителя.
    internal interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
