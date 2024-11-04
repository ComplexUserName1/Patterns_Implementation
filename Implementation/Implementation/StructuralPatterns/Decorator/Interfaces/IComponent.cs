namespace Implementation.StructuralPatterns.Decorator.Interfaces
{
    // Базовый интерфейс Компонента определяет поведение, которое изменяется
    // декораторами.
    internal interface IComponent
    {
        public string Operation();
    }
}
