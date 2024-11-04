using Implementation.StructuralPatterns.Facade.BLClasses.Subsystems;

namespace Implementation.StructuralPatterns.Facade.BLClasses.Facades
{
    // Класс Фасада предоставляет простой интерфейс для сложной логики одной или
    // нескольких подсистем. Фасад делегирует запросы клиентов соответствующим
    // объектам внутри подсистемы. Фасад также отвечает за управление их
    // жизненным циклом. Все это защищает клиента от нежелательной сложности
    // подсистемы.
    internal class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        // Методы Фасада удобны для быстрого доступа к сложной функциональности
        // подсистем. Однако клиенты получают только часть возможностей
        // подсистемы.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
}
