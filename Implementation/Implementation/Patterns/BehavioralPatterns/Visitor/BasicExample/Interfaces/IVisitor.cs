using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteComponents;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces
{
    // Интерфейс Посетителя объявляет набор методов посещения, соответствующих
    // классам компонентов. Сигнатура метода посещения позволяет посетителю
    // определить конкретный класс компонента, с которым он имеет дело.
    internal interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
