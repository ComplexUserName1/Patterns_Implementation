
namespace Implementation.StructuralPatterns.Facade.BLClasses.Subsystems
{
    // Некоторые фасады могут работать с разными подсистемами одновременно.
    internal class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}
