using Implementation.BehavioralPatterns.Interpreter.Interfaces;

namespace Implementation.BehavioralPatterns.Interpreter.BLClasses.Expressions.TerminalExpressions
{
    // терминальное выражение
    internal class NumberExpression : IExpression
    {
        string name; // имя переменной
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
