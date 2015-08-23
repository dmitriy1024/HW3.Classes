using System;

namespace HW3.Classes.Task5
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name){ }

        public override void Read()
        {
            Console.WriteLine(Name + " Reads bad");
        }

        public override void Study()
        {
            Console.WriteLine(Name + " Studies bad");
        }

        public override void Write()
        {
            Console.WriteLine(Name + " Writes bad");
        }
    }
}
