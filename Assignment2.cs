/*Assignment:2
Consider a base class MyClassA { }
with few instance methods inside & a derived class of MyClassA is class MyClassB { }. 
Class MyClassA { }
has only 1 constructor which is parameterized & MyClassB has no user defined constructor. 
Are we able to create an instance of the class MyClassB with following statement in main method 
MyClassB mb1 = new MyClassB();
if yes / no then why ?
<<<YES>>
Because we are inheriting it from class A, so we can create an instance of the MyClassB
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_02
{
    public class MyClassA
    {
        public int a;
        public MyClassA(int a)
        {
            // a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No. stored in a is " + a);
        }
    }
    public class MyClassB : MyClassA
    {
        public MyClassB(int a) : base(a)
        { }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());
            MyClassB mb1 = new MyClassB(a);
            Console.WriteLine(mb1);
        }
    }
}

    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int a=Convert.ToInt32(Console.ReadLine());    
            MyClassB mb1 = new MyClassB(a);
        }
    }
}
*/
