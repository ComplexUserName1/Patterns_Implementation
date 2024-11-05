using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.StartupEntryPoint.BLClasses
{
    internal class StartupContext
    {
        private IPatternImplementationStrategy _strategy;

        public StartupContext()
        { }

        public StartupContext(IPatternImplementationStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IPatternImplementationStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void RunPatternImplementationExample()
        {
            this._strategy.Run();
        }
    }
}
