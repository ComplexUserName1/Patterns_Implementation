using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces
{
    internal interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}
