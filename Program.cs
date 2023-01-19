using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{

    public interface Shweta
    {
         void Manu();
        int Kuttu(int a,int b);
    }

    public interface Mahajan
    {
        void Mahajan();
        int Mahajan(int a,int b);
    }
    public class Ravindra : Shweta,Mahajan
    {
        public void Manu()
        {
            Console.WriteLine("He is my Doggi ");
        }

       public int Kuttu(int a,int b)
        {
            int c;
            c= a+b;
            Console.WriteLine(c);
            return c;
        }

        public void Mahajan()
        {
            Console.WriteLine("This is my name Shweta ");
        }

        public int Mahajan(int a,int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
            return c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shweta s = new Ravindra();
            s.Manu();
            s.Kuttu(1,2);
            Mahajan m = new Ravindra();
            m.Mahajan();
            m.Mahajan(1,2);
        }
    }
}
