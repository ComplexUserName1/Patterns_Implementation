
namespace Implementation.StructuralPatterns.Composite.BLClasses.BasicComponent
{
    // Базовый класс Компонент объявляет общие операции как для простых, так и
    // для сложных объектов структуры.
    internal abstract class Component
    {
        public Component() { }

        // Базовый Компонент может сам реализовать некоторое поведение по
        // умолчанию или поручить это конкретным классам, объявив метод,
        // содержащий поведение абстрактным.
        public abstract string Operation();

        // В некоторых случаях целесообразно определить операции управления
        // потомками прямо в базовом классе Компонент. Таким образом, вам не
        // нужно будет предоставлять  конкретные классы компонентов клиентскому
        // коду, даже во время сборки дерева объектов. Недостаток такого подхода
        // в том, что эти методы будут пустыми для компонентов уровня листа.
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        // Вы можете предоставить метод, который позволит клиентскому коду
        // понять, может ли компонент иметь вложенные объекты.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
