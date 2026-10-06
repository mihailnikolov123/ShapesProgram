using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Rectangle
    {
        public double a;
        public double b;

        public Rectangle(double x, double y)
        {
            a = x;
            b = y;
        }

        public Rectangle(double x)
        {
            a = x;
            b = x;
        }

        public double Area()
        {
            return a * b;
        }
    }
}
