using Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.ConcreteVisitors
{
    internal class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }
}
