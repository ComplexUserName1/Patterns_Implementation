
namespace Implementation.BehavioralPatterns.TemplateMethod.BLClasses.AbstractClass.ConcreteClasses
{
    // Обычно конкретные классы переопределяют только часть операций базового
    // класса.
    internal class ConcreteClass2 : AbstractClassExample
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }
}
