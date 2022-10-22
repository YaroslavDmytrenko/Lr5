using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ExtendsPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
