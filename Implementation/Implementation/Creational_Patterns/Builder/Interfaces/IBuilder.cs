using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
