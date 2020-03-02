﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02
{
   
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 8, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine($"The maximum value in myArray is {maxVal}");
            Console.ReadKey();
        }
    }
}
