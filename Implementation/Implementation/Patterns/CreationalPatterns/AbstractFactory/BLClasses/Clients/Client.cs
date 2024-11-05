using Implementation.Creational_Patterns.Abstract_Factory.Classes.Factory;
using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Factory;

namespace Implementation.Creational_Patterns.Abstract_Factory.Classes.Clients
{
    // Клиентский код работает с фабриками и продуктами только через абстрактные
    // типы: Абстрактная Фабрика и Абстрактный Продукт. Это позволяет передавать
    // любой подкласс фабрики или продукта клиентскому коду, не нарушая его.
    internal class Client
    {
        public void Main()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
