using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading2
{
    internal class Program
    {
        static void Test1()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: "+i);
               
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread 2 is going to sleep ");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 woke up ");
                }
            }
        }
        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 3: " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread T1=new Thread(Test1);  //Just putting this does not display the method
            Thread T2=new Thread(Test2);  //We have to start it first
            Thread T3=new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
        }
    }
}
