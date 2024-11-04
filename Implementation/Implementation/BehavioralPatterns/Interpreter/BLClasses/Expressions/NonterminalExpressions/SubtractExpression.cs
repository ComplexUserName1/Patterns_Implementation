using Implementation.BehavioralPatterns.Interpreter.Interfaces;

namespace Implementation.BehavioralPatterns.Interpreter.BLClasses.Expressions.NonterminalExpressions
{
    // нетерминальное выражение для вычитания
    internal class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }
}
