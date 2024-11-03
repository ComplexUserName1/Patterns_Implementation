
namespace Implementation.Creational_Patterns.Builder.Interfaces
{
    // Интерфейс Строителя объявляет создающие методы для различных частей
    // объектов Продуктов.
    internal interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
