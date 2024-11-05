
namespace Implementation.BehavioralPatterns.TemplateMethod.BLClasses.AbstractClass
{
    // Абстрактный Класс определяет шаблонный метод, содержащий скелет
    // некоторого алгоритма, состоящего из вызовов (обычно) абстрактных
    // примитивных операций.
    //
    // Конкретные подклассы должны реализовать эти операции, но оставить сам
    // шаблонный метод без изменений.
    internal abstract class AbstractClassExample
    {
        // Шаблонный метод определяет скелет алгоритма.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // Эти операции уже имеют реализации.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        // А эти операции должны быть реализованы в подклассах.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // Это «хуки». Подклассы могут переопределять их, но это не обязательно,
        // поскольку у хуков уже есть стандартная (но пустая) реализация. Хуки
        // предоставляют дополнительные точки расширения в некоторых критических
        // местах алгоритма.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
