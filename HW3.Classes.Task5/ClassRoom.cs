using System;
using System.Collections.Generic;

namespace HW3.Classes.Task5
{
    class ClassRoom
    {
        public const int MaxCountOfPupils = 4;
        public string Name { get; private set; }

        private List<Pupil> _pupils = new List<Pupil>(MaxCountOfPupils);

        public Pupil[] Pupils
        {
            get { return _pupils.ToArray(); }
        }

        public ClassRoom(Pupil p1, Pupil p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException();
            else
            {
                _pupils.Add(p1);
                _pupils.Add(p2);
            }
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
            : this(p1, p2)
        {
            if (p3 == null)
                throw new ArgumentNullException();
            else
                _pupils.Add(p3);
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
            : this(p1, p2, p3)
        {
            if (p4 == null)
                throw new ArgumentNullException();
            else
                _pupils.Add(p4);
        }
    }
}
