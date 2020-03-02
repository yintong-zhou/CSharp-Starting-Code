using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch9Ex01
{
    public abstract class MyBase { }
    class MyClass : MyBase { }
    public interface IMyBaseInterface { }
    interface IMyBaseInterface2 : IMyBaseInterface { }
    interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    sealed class MyComplexClass : MyClass, IMyInterface { }

    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
