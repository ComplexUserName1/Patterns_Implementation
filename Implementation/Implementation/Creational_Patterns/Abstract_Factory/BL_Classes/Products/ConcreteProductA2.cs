using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Abstract_Factory.Classes.Products
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    internal class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
