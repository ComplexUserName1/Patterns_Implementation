using Implementation.Creational_Patterns.Abstract_Factory.Interfaces.Products;

namespace Implementation.Creational_Patterns.Abstract_Factory.Classes.Products
{
    // Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    internal class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }

        // Продукт B2 может корректно работать только с Продуктом A2. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в качестве
        // аргумента.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
