using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Components;
using Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces.BLClasses.Decorators.ConcreteDecorators;
using Implementation.StructuralPatterns.Decorator.BLClasses.Clients;
using Implementation.StructuralPatterns.Decorator.Helpers;

namespace Implementation.StructuralPatterns.Decorator.Implementations.GoodImplementationWithClassesAndInterfaces
{
    internal class GoodDecoratorImplementationWithClassesAndInterfaces
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponentWithInterface();

            // Обратите внимание, что декораторы могут обёртывать не только
            // простые компоненты, но и другие декораторы.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);

            ExecuteCustomClient(client, simple, decorator1, decorator2);
        }

        private static void ExecuteCustomClient(Client client, ConcreteComponentWithInterface simple, ConcreteDecoratorA decorator1, ConcreteDecoratorB decorator2)
            => DecoratorImplementationHelper.ExecuteClient(client, simple, decorator1, decorator2);
    }
}
