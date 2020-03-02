using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch09ClassLib;

namespace Ch09Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass MyObj = new MyExternalClass();
            Console.WriteLine(MyObj.ToString());
            Console.ReadKey();

        }
    }
}
