using Implementation.Creational_Patterns.Singletone.Non_Thread_Safe.Classes;

namespace Implementation.Creational_Patterns.Singletone.Non_Thread_Safe
{
    internal class NonThreadSafeSingletonImplementation
    {
        static void Main(string[] args)
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
