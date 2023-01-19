using System;
using System.Globalization;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
  public static class Title
   {
     public static string MyName;
    public static string Surname;
    public static string Result;
    public static string test;
    public static void A() {
                string A = "hello i am shweta ";
                Console.WriteLine("Without Anything " + A);
                TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
                string result;
                result = currentTextInfo.ToTitleCase(A);
                Console.WriteLine("Current Culture :\n " + result);
                result = A.ToLower();
                Console.WriteLine("To Lower case :\n" + result);
                result = A.ToUpper();
                Console.WriteLine(" To Upper case :\n" + result);

                result = "This is \"Shweta Mahajan\"";
                Console.WriteLine(result);

                result = "C:\\Demo\\MS";
                Console.WriteLine(result);
            }
    public static void Appending()
               {
                    MyName = "Shweta";
                    Surname = "Mahjan";
                   Result = string.Format("{0},my name is {0} {1} " ,MyName, Surname);
                   Console.WriteLine(Result);
                   Console.WriteLine("{0},my name is {0} {1} ", MyName, Surname);
                   Result=$"{MyName}, My name is {MyName} {Surname}";
                   Console.WriteLine(Result);


    }
    public static void InterpolationAndLiteral()
              {
                  MyName = "Shweta";
                   Result = $@"C:\Demo {MyName} Test.txt";
                  Console.WriteLine(Result);
               }
    public static void StringBuilderDemo()


    {
        Stopwatch regularStopwatch = new Stopwatch();
        regularStopwatch.Start();
        string test = "";
        for (int i = 0; i < 10000; i++)
        {
            test += i;
        }
        regularStopwatch.Stop();

        Console.WriteLine($"Regular Stopwatch {regularStopwatch.ElapsedMilliseconds} ms");
        
        Stopwatch builderStopwatch = new Stopwatch();
        builderStopwatch.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(i);
        }
        builderStopwatch.Stop();
        Console.WriteLine($"StringBuilder Stopwatch {builderStopwatch.ElapsedMilliseconds} ms");



    }

     public static void WorkingWithArray()


    {
        int[] ages=new int[] {3,5,6,7,8};
        string result;

        result = String.Concat(ages);
        Console.WriteLine(result);

        result=String.Join(",", ages);
        Console.WriteLine(result);

        string testString = "Shw, Tim, Roh, Ruh";
        string[] resultsArray = testString.Split(',');

        Array.ForEach(resultsArray, x => Console.WriteLine(x));

        Console.WriteLine();

        /* testString = "Shw, Tim, Roh, Ruh";
        string[] resultsArray2 = testString.Split(", ");

        Array.ForEach(resultsArray, y => Console.WriteLine(y));

*/
    }

    public static void PadAndTrim()
    {
        string test = "     Hello";
        string result;
        result = test.TrimStart();
        Console.WriteLine($"'{result}'");

        result = test.TrimEnd();
        Console.WriteLine($"'{result}'");

        test = "1.5";
        result=test.PadLeft(10, '5');
        Console.WriteLine(result);

        result = test.PadRight(10, '5');
        Console.WriteLine(result);
    }
    
    public static void SearchStrings()
    {
        string test="This is a string in which i want to search";
        bool resultBoolen;
        int resultInt;

        resultBoolen=test.StartsWith("This is");
        Console.WriteLine($"Starts with \"This is\": {resultBoolen}");

        resultBoolen = test.EndsWith("seaRch");
        Console.WriteLine($"End with \"search\": {resultBoolen}");

        resultBoolen = test.Contains(" is");
        Console.WriteLine($"Contains \" is\": {resultBoolen}");

        resultInt = test.IndexOf("which");
        Console.WriteLine($"Index of  \"which\": {resultInt}");

        resultInt = test.IndexOf("which");
        Console.WriteLine($"Index of  \"which\": {resultInt}");

        resultInt = test.IndexOf("which",5);
        Console.WriteLine($"Index of  \"which\" after character 20: {resultInt}");

    }

    public static void OrderingStrings()
    {

    }

   /* public static void compareToHelper(string testA, string? test8)
    {

    }*/

    public static void GettingASubstring()
    {
        string test = "This is a test string , lets see how its work ";
        string result;

        result=test.Substring(1);
        Console.WriteLine(result);

        result = test.Substring(5,4);
        Console.WriteLine(result);

    }

    public static void ReplaceingText()
    {
        string test = "This is a test string , lets see how its work ";
        string result;

        result = test.Replace("test", "trial");
        Console.WriteLine(result);

       /* result = test.Replace("tesT", "trial",StringComparison.InvariantCultureIgnoreCase);
        Console.WriteLine(result);*/
    }

    public static void InsertingText()
    {
        string test = "This is a test string , lets see how its Insert ";
        string result;

        result = test.Insert(5, "(test) ");
        Console.WriteLine(result);
    }

    public static void RemovingString()
    {

        string test = "This is a test string , lets see how its Remove ";
        string result;

        result = test.Remove(25);
        Console.WriteLine(result);

        result = test.Remove(14,10);
        Console.WriteLine(result);
    }

    public static void Main(String[] args)
     {
        // A();
        // Appending();
        // InterpolationAndLiteral();
        //  StringBuilderDemo();
        // WorkingWithArray();
        //PadAndTrim();
        // SearchStrings();
        //OrderingStrings()
        GettingASubstring();
        // ReplaceingText();
        //InsertingText();
        //RemovingString();






        }
 }     
     
