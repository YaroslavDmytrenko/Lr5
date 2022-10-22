using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
}
