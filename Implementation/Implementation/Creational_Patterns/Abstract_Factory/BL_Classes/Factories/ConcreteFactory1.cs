using Implementation.Creational_Patterns.Abstract_Factory.Classes.Products;
using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Factory;
using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Abstract_Factory.Classes.Factory
{
    // Конкретная Фабрика производит семейство продуктов одной вариации. Фабрика
    // гарантирует совместимость полученных продуктов.  Обратите внимание, что
    // сигнатуры методов Конкретной Фабрики возвращают абстрактный продукт, в то
    // время как внутри метода создается экземпляр  конкретного продукта.
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
