using Implementation.Creational_Patterns.Factory_Method.Interfaces.Products;

namespace Implementation.Creational_Patterns.Factory_Method.BL_Classes.Products
{
    // Конкретные Продукты предоставляют различные реализации интерфейса
    // Продукта.
    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
