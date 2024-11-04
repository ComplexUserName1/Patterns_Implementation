using Implementation.BehavioralPatterns.Interpreter.Interfaces;

namespace Implementation.BehavioralPatterns.Interpreter.BLClasses.Expressions.NonterminalExpressions
{
    // нетерминальное выражение для сложения
    internal class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}
