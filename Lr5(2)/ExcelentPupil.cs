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
            Console.WriteLine("I relax стьльки time what i need, not more");
        }

        public override void Study()
        {
            Console.WriteLine("I'm always go on Deadline, and then i excelent pupil");
        }

        public override void Write()
        {
            Console.WriteLine("I lite to write a lot anything");
        }
    }
}
