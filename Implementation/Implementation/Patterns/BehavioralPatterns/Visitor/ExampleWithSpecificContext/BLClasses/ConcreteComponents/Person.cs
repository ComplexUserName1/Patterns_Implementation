using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents
{
    internal class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}
