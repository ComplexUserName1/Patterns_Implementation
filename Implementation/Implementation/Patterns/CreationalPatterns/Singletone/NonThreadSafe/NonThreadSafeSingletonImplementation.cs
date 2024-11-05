using Implementation.Creational_Patterns.Singletone.Non_Thread_Safe.Classes;
using Implementation.StartupEntryPoint.Interfaces;

namespace Implementation.Creational_Patterns.Singletone.Non_Thread_Safe
{
    internal class NonThreadSafeSingletonImplementation : IPatternImplementationStrategy
    {
        public void Run()
        {
            // Клиентский код.
            NonThreadSafeSingleton s1 = NonThreadSafeSingleton.GetInstance();
            NonThreadSafeSingleton s2 = NonThreadSafeSingleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
