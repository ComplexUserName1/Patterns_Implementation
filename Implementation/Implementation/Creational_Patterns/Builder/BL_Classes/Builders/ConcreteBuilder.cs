using Implementation.Creational_Patterns.Builder.BL_Classes.Products;
using Implementation.Creational_Patterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Builder.BL_Classes.Builders
{
    // Классы Конкретного Строителя следуют интерфейсу Строителя и предоставляют
    // конкретные реализации шагов построения. Ваша программа может иметь
    // несколько вариантов Строителей, реализованных по-разному.
    internal class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // Все этапы производства работают с одним и тем же экземпляром
        // продукта.
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        // Конкретные Строители должны предоставить свои собственные методы
        // получения результатов. Это связано с тем, что различные типы
        // строителей могут создавать совершенно разные продукты с разными
        // интерфейсами. Поэтому такие методы не могут быть объявлены в базовом
        // интерфейсе Строителя (по крайней мере, в статически типизированном
        // языке программирования).
        //
        // Как правило, после возвращения конечного результата клиенту,
        // экземпляр строителя должен быть готов к началу производства
        // следующего продукта. Поэтому обычной практикой является вызов метода
        // сброса в конце тела метода GetProduct. Однако такое поведение не
        // является обязательным, вы можете заставить своих строителей ждать
        // явного запроса на сброс из кода клиента, прежде чем избавиться от
        // предыдущего результата.
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
