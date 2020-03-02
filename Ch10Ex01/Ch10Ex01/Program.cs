using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch10Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object myObj...");
            MyClass myObj = new MyClass("My Object");
            Console.WriteLine("myObj is created.");
            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine($"\nAttemping to assign {i} to myObj.val...");
                    myObj.Val = i;
                    Console.WriteLine($"Value {myObj.Val} assigned to myObj.val.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception {e.GetType().FullName} thrown");
                    Console.WriteLine($"Message:\n\"{e.Message}\"");
               
                    Console.WriteLine("\nOutputting myObj.ToString()...");
                    Console.WriteLine(myObj.ToString());
                    Console.WriteLine("myObj.ToString() Output.");

                    Console.WriteLine("\nmyDoubleIntProp = 5...");
                    Console.WriteLine($"Getting myDoubleIntProp of 5 is {myObj.myDoubleIntProp}");

                    Console.ReadKey();
                }
            }
            
        }
    }
}
