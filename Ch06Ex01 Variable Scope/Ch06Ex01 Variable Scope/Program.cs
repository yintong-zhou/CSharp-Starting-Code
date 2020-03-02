using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex01_Variable_Scope
{
    class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now is Write()");
            Console.WriteLine($"myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global string";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
            Console.ReadKey();
        }
    }
}
