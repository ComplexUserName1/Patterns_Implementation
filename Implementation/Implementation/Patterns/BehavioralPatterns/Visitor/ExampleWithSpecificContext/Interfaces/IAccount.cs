
namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces
{
    internal interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
