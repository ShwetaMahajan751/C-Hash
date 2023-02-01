using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Constructor
{
    public class Employee
    {
        public int id;
        public string name;
/*        public Employee(string Name,int Id)
        {
           name=Name ;
           id = Id;
        }*/
        public  Employee()
        {
            Console.WriteLine("Default ");
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Employee e1 = new Employee("Shweta",3);
            Employee e2 = new Employee("Suku", 4);*/
            Employee e3 = new Employee();

           
        }
    }
}
