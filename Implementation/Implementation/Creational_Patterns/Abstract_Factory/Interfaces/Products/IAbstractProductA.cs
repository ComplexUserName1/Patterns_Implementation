using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products
{
    // Каждый отдельный продукт семейства продуктов должен иметь базовый
    // интерфейс. Все вариации продукта должны реализовывать этот интерфейс.
    internal interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}
