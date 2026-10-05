using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
  public class Rectangle
    {
        public string Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public bool IsFilled { get; set; }

        public double Area(double x, double y)
        {
            return x * y;
        }
        public double Perimeter(double x, double y)
        {
            return 2 * (x + y);
        }
    }

}
