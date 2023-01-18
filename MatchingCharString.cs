using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachingCharInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string 1 ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the string 2 ");
            string str2=Console.ReadLine();
            string res="";
            for(int i = 0; i <str1.Length; i++)
            {
                for(int j = 0; j <str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        res+=str1[i];
                    }
                }
            }
            Console.WriteLine(res);   //Case Sensetive
        }
    }
}
