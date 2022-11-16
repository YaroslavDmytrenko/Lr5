using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad read");
        }

        public override void Study()
        {
            Console.WriteLine("Bad study");   
        }

        public override void Relax()
        {
            Console.WriteLine("Chill out");
        }

        public override void Write()
        {
            Console.WriteLine("I like art on lessons");
        }


    }
}
