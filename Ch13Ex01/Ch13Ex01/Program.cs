﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;

namespace Ch13Ex01
{
    class Program
    {
        static int counter = 0;
        static string displayString = "This string will appear one letter at a time.";

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            myTimer.Start();
            System.Threading.Thread.Sleep(5);
            ReadKey();
        }

        private static void WriteChar(object sender, ElapsedEventArgs e)
        {
            Write(displayString[counter++ % displayString.Length]);
        }

    }
}
