using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteVisitors
{
    internal class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
        }
    }
}
