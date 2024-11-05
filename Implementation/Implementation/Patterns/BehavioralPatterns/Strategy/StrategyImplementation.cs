using Implementation.BehavioralPatterns.Strategy.BLClasses.ConcreteStrategies;
using Implementation.BehavioralPatterns.Strategy.BLClasses.Contexts;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Strategy
{
    internal class StrategyImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            // Клиентский код выбирает конкретную стратегию и передаёт её в
            // контекст. Клиент должен знать о различиях между стратегиями,
            // чтобы сделать правильный выбор.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
