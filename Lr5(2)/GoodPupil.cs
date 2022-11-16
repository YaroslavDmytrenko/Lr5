using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("I can read");
        }

        public override void Relax()
        {
            Console.WriteLine("I can relax when i did all homework");
        }

        public override void Study()
        {
            Console.WriteLine("I am good studing, it's задовільно");
        }

        public override void Write()
        {
            Console.WriteLine("I can write");
        }
    }
}
