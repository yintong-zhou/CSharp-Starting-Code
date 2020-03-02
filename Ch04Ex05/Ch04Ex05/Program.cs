﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            while (balance < interestRate)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine($"{totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
            if (totalYears == 0)
                Console.WriteLine("To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();


        }
    }
}
