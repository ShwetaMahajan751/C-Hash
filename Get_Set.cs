using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



     public class Name
{
      public string name
    {
        get; set;   
    }
      
}
    internal class Program
    {
        static void Main(string[] args)
        {
          Name nam = new Name();
        nam.name = "Shweta";
        Console.WriteLine(nam.name);
          
        }
    }

