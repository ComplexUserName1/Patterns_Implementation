using FacadeClass = Implementation.StructuralPatterns.Facade.BLClasses.Facades.Facade;

namespace Implementation.StructuralPatterns.Facade.BLClasses.Clients
{
    internal class Client
    {
        // Клиентский код работает со сложными подсистемами через простой
        // интерфейс, предоставляемый Фасадом. Когда фасад управляет жизненным
        // циклом подсистемы, клиент может даже не знать о существовании
        // подсистемы. Такой подход позволяет держать сложность под контролем.
        public static void ClientCode(FacadeClass facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
