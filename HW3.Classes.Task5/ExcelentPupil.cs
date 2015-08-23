using System;

namespace HW3.Classes.Task5
{
    class ExcelentPupil : Pupil
    {   
        public ExcelentPupil(string name) : base(name) { }
        
        public override void Read()
        {
            Console.WriteLine(Name + " Reads excelent");
        }

        public override void Study()
        {
            Console.WriteLine(Name + " Studies excelent");
        }

        public override void Write()
        {
            Console.WriteLine(Name + " Writes excelent");
        }
    }
}
