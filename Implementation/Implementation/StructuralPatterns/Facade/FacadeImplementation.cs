using Implementation.StructuralPatterns.Facade.BLClasses.Clients;
using Implementation.StructuralPatterns.Facade.BLClasses.Subsystems;
using FacadeClass = Implementation.StructuralPatterns.Facade.BLClasses.Facades.Facade;

namespace Implementation.StructuralPatterns.Facade
{
    internal class FacadeImplementation
    {
        static void Main(string[] args)
        {
            // В клиентском коде могут быть уже созданы некоторые объекты
            // подсистемы. В этом случае может оказаться целесообразным
            // инициализировать Фасад с этими объектами вместо того, чтобы
            // позволить Фасаду создавать новые экземпляры.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            FacadeClass facade = new FacadeClass(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
