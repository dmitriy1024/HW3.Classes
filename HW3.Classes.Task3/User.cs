using System;

namespace HW3.Classes.Task3
{
    class User
    {
        public string LogIn { get; private set; }
        public string Name { get; private set; }
        public string SName { get; private set; }
        public readonly DateTime BirthDate;
        public readonly DateTime FillFormDate;

        public User(string login, string name, string sname, DateTime birthDate)
        {
            if (login == null || name == null || sname == null)
                throw new ArgumentNullException();
            else
            {
                LogIn = login;
                Name = name;
                SName = sname;
                BirthDate = birthDate;
                FillFormDate = DateTime.Now;
            }           
        }
    }
}
