using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex05
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;
        static double Sum(double param1, double param2) => param1 + param2;
        static double Sub(double param1, double param2) => param1 - param2;
        static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.WriteLine("Enter 2 number separated with a semicolon:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(';');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter\n +\n -\n *\n /");
            input = Console.ReadLine();
            if (input == "*")
                process = new ProcessDelegate(Multiply);
            
                process = new ProcessDelegate(Divide);

            if (input == "+")
                process = new ProcessDelegate(Sum);
            else
                process = new ProcessDelegate(Sub);

            Console.WriteLine($"Result: {process(param1, param2)}");
            Console.ReadKey();

                     
        }
    }
}
