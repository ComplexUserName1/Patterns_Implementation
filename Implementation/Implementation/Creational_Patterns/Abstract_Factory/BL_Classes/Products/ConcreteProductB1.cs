using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Abstract_Factory.Classes.Products
{
    // Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        // Продукт B1 может корректно работать только с Продуктом A1. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в
        // качестве аргумента.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
