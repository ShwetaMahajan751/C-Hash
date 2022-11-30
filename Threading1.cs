using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading1
{
    internal class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 1 " + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 2 " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main thread is going to sleep ");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thread is going to wake up ");
                }

            }
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 3 " + i);
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
        }
    }
}




