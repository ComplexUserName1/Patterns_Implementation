using Implementation.BehavioralPatterns.Command.BLClasses.Commands;
using Implementation.BehavioralPatterns.Command.BLClasses.Invokers;
using Implementation.BehavioralPatterns.Command.BLClasses.Receivers;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.BehavioralPatterns.Command
{
    internal class CommandImplementation : IPatternImplementationStrategy
    {
        public void Run()
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
