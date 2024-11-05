using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteVisitors
{
    internal class XmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.Name + "</Name>" +
                "<Number>" + acc.Number + "</Number><Person>\n";
            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" +
                "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                "<Number>" + acc.Number + "</Number><Company>\n";
            Console.WriteLine(result);
        }
    }
}
