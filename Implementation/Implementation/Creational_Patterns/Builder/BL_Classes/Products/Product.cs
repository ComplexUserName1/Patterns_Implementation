using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Builder.BL_Classes.Products
{
    // Имеет смысл использовать паттерн Строитель только тогда, когда ваши
    // продукты достаточно сложны и требуют обширной конфигурации.
    //
    // В отличие от других порождающих паттернов, различные конкретные строители
    // могут производить несвязанные продукты. Другими словами, результаты
    // различных строителей  могут не всегда следовать одному и тому же
    // интерфейсу.
    internal class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
