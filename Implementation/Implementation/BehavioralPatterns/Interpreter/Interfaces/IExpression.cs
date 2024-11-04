using Implementation.BehavioralPatterns.Interpreter.BLClasses;

namespace Implementation.BehavioralPatterns.Interpreter.Interfaces
{
    // интерфейс интерпретатора
    internal interface IExpression
    {
        int Interpret(Context context);
    }
}
