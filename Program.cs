using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first no ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second no ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(FormatException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }
            Console.WriteLine("End of the program ");
           

        }
    }
}
