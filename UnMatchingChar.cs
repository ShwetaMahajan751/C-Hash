using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnMatchingChar
{
    class A
    {
        static int MAX_CHAR = 1000;
         static void S(string str1,string str2)
        {
            int[] a=new int [MAX_CHAR];
            
            for(int i = 0; i < MAX_CHAR; i++)
            {
                a[i] = 0;
            }
            int l1 = str1.Length;
            int l2 = str2.Length;

            for(int i = 0; i < l1; i++)
            {
                a[str1[i] - 'a'] = 1;
            }

            for(int i = 0; i < l2; i++)
            {
                if (a[str2[i] - 'a'] == 1 || a[str2[i] - 'a'] == -1)
                {
                    a[str2[i] - 'a'] = -1;
                }

                else
                {
                    a[str2[i] - 'a'] = 2;
                }
            }
            Console.WriteLine("The Unmatched char is ");

            for(int i = 0; i < MAX_CHAR; i++)
            {
                if (a[i]==1 || a[i] == 2)
                {
                    Console.WriteLine((char) (i+'a')+" ");
                }
            }

        }
    
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1 ");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter string 2 ");
            string str2=Console.ReadLine();
            S(str1, str2);
           
        }
    }
}
