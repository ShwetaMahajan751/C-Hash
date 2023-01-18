using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder2
{
   public static class StringBuilders
    {
        
        public static void Appends(StringBuilder a)
        {
            Console.WriteLine("Enter the string to be apended");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            a.Append(sb);
            Console.WriteLine(a);
        }

        public static void Inserts()
        {
            Console.WriteLine("Enter the string u want to insert (shweta )");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            sb.Insert(2, "Mahajan");
            Console.WriteLine(sb);
        }

        public static void Replaces(StringBuilder n)
        {
            n.Replace("Hii","Hello");
            Console.WriteLine(n);
        }

        public static void Removes(StringBuilder n)
        {
            n.Remove(2, 8);
            Console.WriteLine(n);
        }


    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            StringBuilder n = new StringBuilder("Hii I am Shweta Mahajan ");
            Console.WriteLine(n);
            StringBuilders.Appends(n);
            StringBuilders.Inserts();
            StringBuilders.Replaces(n);
            StringBuilders.Removes(n);

        }
    }
}
