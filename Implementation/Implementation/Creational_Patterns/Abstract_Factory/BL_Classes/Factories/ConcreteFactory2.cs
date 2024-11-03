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
    // Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
