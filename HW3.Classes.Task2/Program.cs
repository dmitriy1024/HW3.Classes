using System;

namespace HW3.Classes.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig = new Figure(
                            new Point(4, 4, "A"), 
                            new Point(4, -4, "B"), 
                            new Point(-4, -4, "C"), 
                            new Point(-7, 0, "D"),
                            new Point(-4, 4, "E"));
            Console.WriteLine("Name of the figure : {0}", fig.Name);
            Console.WriteLine("Perimeter of the figure : {0}", fig.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
