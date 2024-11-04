using Implementation.StructuralPatterns.Composite.BLClasses.BasicComponent;

namespace Implementation.StructuralPatterns.Composite.BLClasses.SpecificComponents.SimpleComponents
{
    // Класс Лист представляет собой конечные объекты структуры. Лист не может
    // иметь вложенных компонентов.
    //
    // Обычно объекты Листьев выполняют фактическую работу, тогда как объекты
    // Контейнера лишь делегируют работу своим подкомпонентам.
    internal class LeafComponent : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
