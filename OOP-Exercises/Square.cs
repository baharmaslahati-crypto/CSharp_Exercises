using System;
using System.Collections.Generic;
using System.Text;
s
namespace OOP_Exercises
{
    public class Square
    {
        public string Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public bool IsFilled { get; set; }

        public double Area(double x)
        {
            return x * x;
        }
        public double Perimeter(double x)
        {
            return 4 * x;
        }

    }
}
