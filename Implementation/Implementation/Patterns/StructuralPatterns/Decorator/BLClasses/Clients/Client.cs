using Implementation.StructuralPatterns.Decorator.Interfaces;

namespace Implementation.StructuralPatterns.Decorator.BLClasses.Clients
{
    internal class Client : IClient
    {
        // Клиентский код работает со всеми объектами, используя интерфейс
        // Компонента. Таким образом, он остаётся независимым от конкретных
        // классов компонентов, с которыми работает.
        public void ClientCode(IComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
