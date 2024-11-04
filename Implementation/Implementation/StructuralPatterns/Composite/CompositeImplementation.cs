using Implementation.StructuralPatterns.Composite.BLClasses.Clients;
using Implementation.StructuralPatterns.Composite.BLClasses.SpecificComponents;
using Implementation.StructuralPatterns.Composite.BLClasses.SpecificComponents.SimpleComponents;

namespace Implementation.StructuralPatterns.Composite
{
    internal class CompositeImplementation
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            // Таким образом, клиентский код может поддерживать простые
            // компоненты-листья...
            LeafComponent leaf = new LeafComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...а также сложные контейнеры.
            CompositeComponent tree = new CompositeComponent();
            CompositeComponent branch1 = new CompositeComponent();
            branch1.Add(new LeafComponent());
            branch1.Add(new LeafComponent());
            CompositeComponent branch2 = new CompositeComponent();
            branch2.Add(new LeafComponent());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
