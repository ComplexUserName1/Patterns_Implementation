using Implementation.BehavioralPatterns.Visitor.BasicExample.Interfaces;

namespace Implementation.BehavioralPatterns.Visitor.BasicExample.BLClasses.Clients
{
    internal class Client
    {
        // Клиентский код может выполнять операции посетителя над любым набором
        // элементов, не выясняя их конкретных классов. Операция принятия
        // направляет вызов к соответствующей операции в объекте посетителя.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
