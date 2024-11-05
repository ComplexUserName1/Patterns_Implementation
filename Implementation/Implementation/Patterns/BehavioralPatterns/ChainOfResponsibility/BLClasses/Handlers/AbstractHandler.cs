using Implementation.BehavioralPatterns.ChainOfResponsibility.Interfaces;

namespace Implementation.BehavioralPatterns.ChainOfResponsibility.BLClasses.Handlers
{
    // Поведение цепочки по умолчанию может быть реализовано внутри базового
    // класса обработчика.
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Возврат обработчика отсюда позволит связать обработчики простым
            // способом, вот так:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
