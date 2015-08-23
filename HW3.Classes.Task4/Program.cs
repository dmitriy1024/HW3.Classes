using System;

namespace HW3.Classes.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(1,1,0.15,"Iphone", 10, 599);
            Console.WriteLine("10 iphones wihout VAT cost {0:f2}$", invoice.CalcCostWithoutVAT());
            Console.WriteLine("10 iphones wihh VAT cost {0:f2}$", invoice.CalcCostWithVAT());

            Console.ReadKey();
        }
    }
}
