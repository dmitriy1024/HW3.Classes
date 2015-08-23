using System;
using System.Collections.Generic;

namespace HW3.Classes.Task2
{
    class Figure
    {
        public const int MaxCapacity = 5;
        private List<Point> _points = new List<Point>(MaxCapacity);
        
        public string Name
        {
            get
            {
                string name = "";
                foreach (var item in _points)                
                    name += item.Name;
                return name;
            }
        }

        /// <summary>
        /// Передавать последовательно сопряженные вершины
        /// </summary>
        public Figure(Point a, Point b, Point c)
        {   
            if(a == null || b == null || c == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _points.Add(a);
                _points.Add(b);
                _points.Add(c);
            }
        }
        
        /// <summary>
        /// Передавать последовательно сопряженные вершины
        /// </summary>
        public Figure(Point a, Point b, Point c, Point d)
            : this(a, b, c)
        {
            if(d == null)            
                throw new ArgumentNullException();            
            else            
                _points.Add(d);            
        }


        public Figure(Point a, Point b, Point c, Point d, Point e)
            : this(a, b, c, d)
        {
            if (e == null)
                throw new ArgumentNullException();
            else
                _points.Add(e);
        }

        public double PerimeterCalculator()
        {
            double perim = 0;
            for (int i = 1; i < _points.Count; i++)
                perim += LengthSide(_points[i - 1], _points[i]);
            perim += LengthSide(_points[_points.Count - 1], _points[0]);

            return perim;
        }

        private double LengthSide(Point a, Point b)
        {
            Point lengthPoint = new Point(a.X - b.X, a.Y - b.Y, "length point");
            double length = Math.Sqrt(Math.Pow(lengthPoint.X, 2) + Math.Pow(lengthPoint.Y, 2));
            return length;
        }
    }
}
