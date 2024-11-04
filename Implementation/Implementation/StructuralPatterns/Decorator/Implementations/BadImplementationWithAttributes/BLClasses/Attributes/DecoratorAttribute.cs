
namespace Implementation.StructuralPatterns.Decorator.Implementations.BadImplementationWithAttributes.BLClasses.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class DecoratorAttribute : Attribute
    {
        public Type DecoratorType { get; }

        public DecoratorAttribute(Type decoratorType)
        {
            DecoratorType = decoratorType;
        }
    }
}
