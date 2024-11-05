using Implementation.BehavioralPatterns.Interpreter.BLClasses.Expressions.NonterminalExpressions;
using Implementation.BehavioralPatterns.Interpreter.BLClasses.Expressions.TerminalExpressions;
using Implementation.BehavioralPatterns.Interpreter.BLClasses;
using Implementation.BehavioralPatterns.Interpreter.Interfaces;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Interpreter
{
    internal class InterpreterImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Context context = new Context();
            // определяем набор переменных
            int x = 5;
            int y = 8;
            int z = 2;

            // добавляем переменные в контекст
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            // создаем объект для вычисления выражения x + y - z
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")
                ),
                new NumberExpression("z")
            );

            int result = expression.Interpret(context);
            Console.WriteLine("x=5\ny=8\nz=2\nx+y-z");
            Console.WriteLine("Result: {0}", result);

            Console.Read();
        }
    }
}
