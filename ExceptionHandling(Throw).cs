using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Throw_
{


    public class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get { return "Attempted to divide from odd number"; }
        }
    }
    
    internal class ThrowDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int b=Convert.ToInt32(Console.ReadLine());
            
            if (b % 2> 0)
            {
                throw new DivideByOddNumberException();
            }
            int c = a / b;
            Console.WriteLine(c);
            Console.WriteLine("end of the program ");
        }
    }
}
