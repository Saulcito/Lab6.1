using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    internal class Program
    {
        static double CalculateExpression(double x, double y)
        {
            return (x + Math.Sin(y)) / (Math.Sin(x) + y);
        }
        static void Main(string[] args)
        {
            double Term1 = CalculateExpression(1, 4);
            double Term2 = CalculateExpression(7, 5);
            double Term3 = CalculateExpression(3, 2);

            double y = Term1 + Term2 + Term3;
            Console.WriteLine($"The value of y is {y:F10}");
            Console.ReadKey();
        }
    }
}
