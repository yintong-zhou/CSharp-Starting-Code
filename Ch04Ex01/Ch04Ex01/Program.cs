﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0and5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? { isBetween0and5}");
            Console.WriteLine($"Integer one of the above is true? {isLessThan10 ^ isBetween0and5}");
            Console.ReadKey();

        }
    }
}
