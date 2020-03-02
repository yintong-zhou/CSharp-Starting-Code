using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            double first_num, second_num;
            string user_name;
            Console.WriteLine("Enter your name:");
            user_name = Console.ReadLine();
            Console.WriteLine($"Welcome {user_name}!");
            Console.WriteLine("Give me a number:");
            first_num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me another number:");
            second_num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {first_num} and {second_num} is " + $" {first_num + second_num}.");
            Console.WriteLine($"The result of subtracting {first_num} and {second_num} is " + $" {first_num - second_num}.");
            Console.WriteLine($"The product of {first_num} and {second_num} is " + $" {first_num * second_num}.");
            Console.WriteLine($"The result of dividing {first_num} and {second_num} is " + $" {first_num / second_num}.");
            Console.WriteLine($"The remainder after dividing {first_num} by " + $"{second_num} is {first_num % second_num}.");
            Console.ReadLine();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
