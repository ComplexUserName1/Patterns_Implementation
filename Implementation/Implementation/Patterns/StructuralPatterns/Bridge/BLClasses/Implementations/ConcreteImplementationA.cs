using Implementation.Structural_Patterns.Bridge.Interfaces;

namespace Implementation.Structural_Patterns.Bridge.BL_Classes.Implementations
{
    // Каждая Конкретная Реализация соответствует определённой платформе и
    // реализует интерфейс Реализации с использованием API этой платформы.
    internal class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
