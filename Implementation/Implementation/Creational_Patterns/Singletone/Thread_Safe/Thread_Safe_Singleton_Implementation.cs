using Implementation.Creational_Patterns.Singletone.Thread_Safe.Classes;

namespace Implementation.Creational_Patterns.Singletone.Thread_Safe
{
    internal class Thread_Safe_Singleton_Implementation
    {
        static void Main(string[] args)
        {
            // Клиентский код.

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            Thread_Safe_Singleton singleton = Thread_Safe_Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
