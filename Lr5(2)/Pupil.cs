using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal abstract class Pupil
    {
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

        public void All()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
