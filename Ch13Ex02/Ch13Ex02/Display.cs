using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex02
{
    class Display
    {
        public void DisplayMessage(string message) 
            => Console.WriteLine($"Message arrived: {message}");
    }
}
