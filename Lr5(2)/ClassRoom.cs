using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ClassRoom
    {
        List<Pupil> pupils = new List<Pupil>();
        public ClassRoom(List<Pupil> pupils)
        {
            this.pupils = pupils;
        }

        /*public void Add(Pupil pupil)
        {
           pupils.Add(pupil);
        }*/

        public void Info()
        {
            int c = pupils.Count;
            foreach (Pupil p in pupils)
            {
                if (p != null)
                {
                    p.All();
                }
            }
        }
        
    }
}
