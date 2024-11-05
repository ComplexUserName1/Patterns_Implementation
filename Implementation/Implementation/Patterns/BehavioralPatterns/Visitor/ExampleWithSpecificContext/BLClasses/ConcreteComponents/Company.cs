using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents
{
    internal class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAc(this);
        }
    }
}
