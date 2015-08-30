using System;

namespace HW3.Classes.Task3
{
    class Program
    {
        static void Main(string[] args)
        {   
            var user = new User("vasya123", "Vasiliy", "Ivanov", new DateTime(1990, 10, 15));
            Console.WriteLine("User {0} {1}", user.Name, user.SName);
            Console.WriteLine("BirthDate {0:dd/MM/yyyy}", user.BirthDate);
            Console.WriteLine("Date of filling form {0}", user.FillFormDate);

            Console.ReadKey();
        }
    }
}
