﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex01
{
    class MyClass
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get { return intVal; }
            set
            {
                if (Val >= 0 && Val <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value,
                       "Val must be assigned a value between 0 and 10."));
            }
        }
        public override string ToString() => "Name: " + Name + "\nVal: " + Val;
        private MyClass() : this("Default Name") { }
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        private int myDoubleInt;
        public int myDoubleIntProp => (myDoubleInt * 2);

    }
   
}
