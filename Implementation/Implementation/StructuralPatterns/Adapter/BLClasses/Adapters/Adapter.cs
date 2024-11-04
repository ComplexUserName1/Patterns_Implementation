using Implementation.Structural_Patterns.Adapter.BL_Classes.Adaptees;
using Implementation.Structural_Patterns.Adapter.Interfaces;

namespace Implementation.Structural_Patterns.Adapter.BL_Classes.Adapters
{
    // Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
    // интерфейсом.
    internal class AdapterClass : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterClass(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}
