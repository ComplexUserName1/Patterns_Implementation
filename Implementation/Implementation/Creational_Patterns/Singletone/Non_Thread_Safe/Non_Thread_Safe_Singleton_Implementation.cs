using Implementation.Creational_Patterns.Singletone.Non_Thread_Safe.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Creational_Patterns.Singletone.Non_Thread_Safe
{
    internal class Non_Thread_Safe_Singleton_Implementation
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Non_Thread_Safe_Singleton s1 = Non_Thread_Safe_Singleton.GetInstance();
            Non_Thread_Safe_Singleton s2 = Non_Thread_Safe_Singleton.GetInstance();

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
