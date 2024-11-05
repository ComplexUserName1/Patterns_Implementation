using Implementation.BehavioralPatterns.Strategy.Interfaces;

namespace Implementation.BehavioralPatterns.Strategy.BLClasses.ConcreteStrategies
{
    // Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    internal class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
