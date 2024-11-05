using Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteComponents
{
    // Каждый Конкретный Компонент должен реализовать метод Accept таким
    // образом, чтобы он вызывал метод посетителя, соответствующий классу
    // компонента.
    internal class ConcreteComponentB : IComponent
    {
        // То же самое здесь: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}
