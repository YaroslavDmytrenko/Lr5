using System;
using System.Collections.Generic;

namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> AllPupils = new List<Pupil>();
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();
            AllPupils.Add(excelentPupil);
            AllPupils.Add(goodPupil);
            AllPupils.Add(badPupil);
            ClassRoom classRoom = new ClassRoom(AllPupils);
            classRoom.Info();
        }

    }
}
