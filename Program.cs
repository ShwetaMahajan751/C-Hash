using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str=Console.ReadLine();
            int n = str.Length;
            string rev = "";
            while(n>0)
            {
                rev+=str[n-1];
                n--;
            }
            Console.WriteLine("The reversed string is: "+rev);
            if (str == rev)
            {
                Console.WriteLine("The string is palindrome ");
            }
            else
            {
                Console.WriteLine("The string is not palindrome ");
            }
        }
    }
}
