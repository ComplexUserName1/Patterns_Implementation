using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Factory_Method.Interfaces.Products
{
    // Интерфейс Продукта объявляет операции, которые должны выполнять все
    // конкретные продукты.
    internal interface IProduct
    {
        string Operation();
    }
}
