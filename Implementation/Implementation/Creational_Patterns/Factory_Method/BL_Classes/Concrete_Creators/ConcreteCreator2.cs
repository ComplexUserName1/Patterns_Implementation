using Implementation.Creational_Patterns.Factory_Method.BL_Classes.Creators;
using Implementation.Creational_Patterns.Factory_Method.BL_Classes.Products;
using Implementation.Creational_Patterns.Factory_Method.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Factory_Method.BL_Classes.Concrete_Creators
{
    // Конкретные Создатели переопределяют фабричный метод для того, чтобы
    // изменить тип результирующего продукта.
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
