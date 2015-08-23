using System;

namespace HW3.Classes.Task1
{
    class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            if (side1 > 0 && side2 > 0)
            {
                _side1 = side1;
                _side2 = side2;
            }
            else
            {
                throw new ArgumentException("Parameters must be positive!");
            }
        }

        public double Area
        {
            get { return _side1 * _side2; }
        }

        public double Perimeter
        {
            get { return (_side1 + _side2) * 2; }
        }

        public double AreaCalculator()
        {
            return Area;
        }

        public double PerimeterCalculator()
        {
            return Perimeter;
        }
    }
}
