using System;

namespace HW3.Classes.Task2
{
    class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
    }
}
