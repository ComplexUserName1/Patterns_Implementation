using Implementation.StructuralPatterns.Composite.BLClasses.BasicComponent;

namespace Implementation.StructuralPatterns.Composite.BLClasses.Clients
{
    internal class Client
    {
        // Клиентский код работает со всеми компонентами через базовый
        // интерфейс.
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        // Благодаря тому, что операции управления потомками объявлены в базовом
        // классе Компонента, клиентский код может работать как с простыми, так
        // и со сложными компонентами, вне зависимости от их конкретных классов.
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
