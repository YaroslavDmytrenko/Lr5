using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("I can good read");
        }

        public override void Relax()
        {
            Console.WriteLine("I relax as much as I need no more");
        }

        public override void Study()
        {
            Console.WriteLine("I always hand in my work on time");
        }

        public override void Write()
        {
            Console.WriteLine("I like to write a lot anything");
        }
    }
}
