using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Ex03
{
    class MyClass
    {
        public int val;
    }
    struct MyStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ObjectA = new MyClass();
            MyClass ObjectB = ObjectA;
            ObjectA.val = 10;
            ObjectB.val = 20;
            MyStruct StructA = new MyStruct();
            MyStruct StructB = StructA;
            StructA.val = 30;
            StructB.val = 40;
            Console.WriteLine($"ObjectA.val = {ObjectA.val}");
            Console.WriteLine($"ObjectB.val = {ObjectB.val}");
            Console.WriteLine($"StructA.val = {StructA.val}");
            Console.WriteLine($"StructB.val = {StructB.val}");
            Console.ReadKey();


        }
    }
}
