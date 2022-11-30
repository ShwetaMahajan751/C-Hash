using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading3Constructor
{
    internal class Program
    {
        static void test()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 1: " + i);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart obj = new ThreadStart(test); //Single parameter constructor
            Thread T1 = new Thread(obj);
            T1.Start();
            Console.WriteLine();
        }
    }
}



