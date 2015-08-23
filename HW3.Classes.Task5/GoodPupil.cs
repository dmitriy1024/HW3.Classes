using System;

namespace HW3.Classes.Task5
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name){ }

        public override void Read()
        {
            Console.WriteLine(Name + " Reads good");
        }

        public override void Study()
        {
            Console.WriteLine(Name + " Sdudies good");
        }

        public override void Write()
        {
            Console.WriteLine(Name + " Writes good");
        }
    }
}
