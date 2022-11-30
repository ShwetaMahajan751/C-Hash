/*Assignment:1
Consider Class Demo1 with instance methods D1() and D2().
The class Demo1 has only 1 user-defined constructor and it is marked as private. 
Considering the above situation, we can not instantiate the class Demo1 in any other class and also can not be able to access its method. 
You are allowed to modify the class but do not add a constructor, do not inherit the class Demo1 &also do not modify the existing constructor.
Try to find the solution to access the instance methods D1 and D2.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



class Demo1
{
    //public int a;
    private void D1()
    {
        Console.WriteLine("This is private Method D1 \n");
    }

    private void D2()
    {
        Console.WriteLine("This is private method D2 \n");
    }

    private Demo1
    {
        Console.WriteLine("This is constructor ");
    }


}
class Program
{
    static void Main(string[] args)
    {
        typeof(Demo1).GetMethod("D1", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Demo1(), null);
        typeof(Demo1).GetMethod("D2", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Demo1(), null);
        typeof(Demo1).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
        

    }
}



