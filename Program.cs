/*if we give a return statement the end of program will not executed but the finally block will execute,there is not any chance to excape feom it......
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Finally_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a no ");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second no ");
                int b=Convert.ToInt32(Console.ReadLine());
                int c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This block will excecute any how ");
            }

            Console.WriteLine("End of the program ");
        }
    }
}
