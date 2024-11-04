using Implementation.BehavioralPatterns.ChainOfResponsibility.BLClasses.Clients;
using Implementation.BehavioralPatterns.ChainOfResponsibility.BLClasses.Handlers;

namespace Implementation.BehavioralPatterns.ChainOfResponsibility
{
    internal class ChainOfResponsobilityImplementation
    {
        static void Main(string[] args)
        {
            // Другая часть клиентского кода создает саму цепочку.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // Клиент должен иметь возможность отправлять запрос любому
            // обработчику, а не только первому в цепочке.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}
