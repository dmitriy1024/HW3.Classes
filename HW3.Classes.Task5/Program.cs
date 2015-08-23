using System;

namespace HW3.Classes.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom(
                            new BadPupil("Vasya"),
                            new GoodPupil("Petya"),
                            new ExcelentPupil("Vova"),
                            new ExcelentPupil("Dima"));
            Pupil[] pupilsInClass = classRoom.Pupils;

            Console.WriteLine("SITUATION IN CLASSROOM");
            foreach (var item in pupilsInClass)
            {
                item.Read();
                item.Write();
                item.Study();
            }

            Console.ReadKey();
        }
    }
}
