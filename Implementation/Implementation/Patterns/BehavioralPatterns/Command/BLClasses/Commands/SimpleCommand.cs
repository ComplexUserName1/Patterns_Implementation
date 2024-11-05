using Implementation.BehavioralPatterns.Command.Interfaces;

namespace Implementation.BehavioralPatterns.Command.BLClasses.Commands
{
    // Некоторые команды способны выполнять простые операции самостоятельно.
    internal class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}
