using Implementation.StartupEntryPoint.Interfaces;
using Implementation.StructuralPatterns.Proxy.BLClasses.Clients;
using Implementation.StructuralPatterns.Proxy.BLClasses.Subjects;
using ProxyClass = Implementation.StructuralPatterns.Proxy.BLClasses.Proxy;

namespace Implementation.StructuralPatterns.Proxy
{
    internal class ProxyImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyClass proxy = new ProxyClass(realSubject);
            client.ClientCode(proxy);
        }
    }
}
