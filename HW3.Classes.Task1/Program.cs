using System;

namespace HW3.Classes.Task1
{
    class Program//добавть try catch
    {
        static void Main(string[] args)
        {
            string enteredStr;
            double side1, side2;
            Rectangle rect;

            while(true)
            {
                Console.WriteLine("Enter the first side of rectangle -> (x to exit)");
                enteredStr = Console.ReadLine();
                if (enteredStr == "x")
                    break;
                if (!Double.TryParse(enteredStr, out side1))
                {
                    Console.WriteLine("Invalid format!");
                    continue;
                }

                Console.WriteLine("Enter the second side of rectangle -> (x to exit)");
                enteredStr = Console.ReadLine();
                if (enteredStr == "x")
                    break;
                if (!Double.TryParse(enteredStr, out side2))
                {
                    Console.WriteLine("Invalid format!");
                    continue;
                }

                if(side1 > 0 && side2 > 0)
                {
                    rect = new Rectangle(side1, side2);
                    Console.WriteLine("Area of rectangle = {0}", rect.Area);
                    Console.WriteLine("Perimeter of rectangle = {0}", rect.Perimeter);
                }
                else
                    Console.WriteLine("Side must be > 0. Try again!");
            }
        }
    }
}
