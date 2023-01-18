using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str1=Console.ReadLine();
            string rev = "";
            int n = str1.Length;
            while(n>0)
            {
                rev += str1[n - 1];
                n--;
            }
            Console.WriteLine(rev);
           


        }
    }
}
