using System;

namespace HW3.Classes.Task5
{
    abstract class Pupil
    {   
        public string Name { get; protected set; }

        abstract public void Study();
        abstract public void Read();
        abstract public void Write();

        public Pupil(string name)
        {
            Name = name;
        }
    }
}
