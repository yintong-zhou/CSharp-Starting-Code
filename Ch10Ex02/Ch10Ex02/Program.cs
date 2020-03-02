using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State
        {
            get { return State; }
        }
        
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA myObjet = new ClassA();
            Console.WriteLine($"myObjet.State = {myObjet.State}");
            ClassA.ClassB myOtherObjet = new ClassA.ClassB();
            myOtherObjet.SetPrivateState(myObjet, 999);
            Console.WriteLine($"myObjet.State = {myObjet.State}");
            Console.ReadKey();
        }
    }
}
