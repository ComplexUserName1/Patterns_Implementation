using Implementation.BehavioralPatterns.Strategy.Interfaces;

namespace Implementation.BehavioralPatterns.Strategy.BLClasses.ConcreteStrategies
{
    internal class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
