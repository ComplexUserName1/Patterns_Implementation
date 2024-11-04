using Implementation.BehavioralPatterns.Command.BLClasses.Commands;
using Implementation.BehavioralPatterns.Command.BLClasses.Invokers;
using Implementation.BehavioralPatterns.Command.BLClasses.Receivers;

namespace Implementation.BehavioralPatterns.Command
{
    internal class CommandImplementation
    {
        static void Main(string[] args)
        {
            // Клиентский код может параметризовать отправителя любыми
            // командами.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
