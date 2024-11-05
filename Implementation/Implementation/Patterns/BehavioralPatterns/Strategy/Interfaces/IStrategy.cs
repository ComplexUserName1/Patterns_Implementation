
namespace Implementation.BehavioralPatterns.Strategy.Interfaces
{
    // Интерфейс Стратегии объявляет операции, общие для всех поддерживаемых
    // версий некоторого алгоритма.
    //
    // Контекст использует этот интерфейс для вызова алгоритма, определённого
    // Конкретными Стратегиями.
    internal interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
