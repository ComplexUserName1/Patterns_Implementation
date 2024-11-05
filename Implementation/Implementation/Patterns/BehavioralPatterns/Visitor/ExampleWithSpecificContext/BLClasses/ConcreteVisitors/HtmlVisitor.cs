using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteComponents;
using Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.ExampleWithSpecificContext.BLClasses.ConcreteVisitors
{
    internal class HtmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<table><tr><td>Property<td><td>Value</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>\n";
            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Company acc)
        {
            string result = "<table><tr><td>Property<td><td>Value</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>\n";
            Console.WriteLine(result);
        }
    }
}
