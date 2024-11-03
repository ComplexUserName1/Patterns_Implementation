using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products;

namespace Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Factory
{
    // Интерфейс Абстрактной Фабрики объявляет набор методов, которые возвращают
    // различные абстрактные продукты.  Эти продукты называются семейством и
    // связаны темой или концепцией высокого уровня. Продукты одного семейства
    // обычно могут взаимодействовать между собой. Семейство продуктов может
    // иметь несколько вариаций,  но продукты одной вариации несовместимы с
    // продуктами другой.
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
