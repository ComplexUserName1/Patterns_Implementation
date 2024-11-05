using Implementation.BehavioralPatterns.TemplateMethod.BLClasses.AbstractClass;

namespace Implementation.BehavioralPatterns.TemplateMethod.BLClasses.Clients
{
    internal class Client
    {
        // Клиентский код вызывает шаблонный метод для выполнения алгоритма.
        // Клиентский код не должен знать конкретный класс объекта, с которым
        // работает, при условии, что он работает с объектами через интерфейс их
        // базового класса.
        public static void ClientCode(AbstractClassExample abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }
}
