using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using static System.Console;

namespace Ch13Ex06
{
    class Myclass1
    {
        public int Add(int var1, int var2) => var1 + var2;
        /*public int Add(int var1, int var2)
        {
            return var1 + var2;
        }*/
    }
    class Myclass2
    {

    }
    class Program
    {
        static int callCount = 0;
        static dynamic GetValue()
        {
            if(callCount++ == 0)
            {
                return new Myclass1();
            }
            return new Myclass2();
        }
        static void Main(string[] args)
        {
            try
            {
                dynamic firstResult = GetValue();
                dynamic secondResult = GetValue();
                WriteLine($"firstResult is: {firstResult.ToString()}");
                WriteLine($"secondResult is: {secondResult.ToString()}");
                WriteLine("");
                WriteLine($"firstResult call: {firstResult.Add(2, 3)}");
                WriteLine($"secondResult call: {secondResult.Add(2, 3)}");
            }
            catch(RuntimeBinderException ex)
            {
                WriteLine(ex.Message);
            }
            ReadKey();
        }
    }
}
