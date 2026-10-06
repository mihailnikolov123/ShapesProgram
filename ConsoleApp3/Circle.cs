using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Circle
    {
        public double r;

        public Circle(double x)
        {
            r = x;
        }

        public Circle()
        {
            r = 1;
        }

        public double Area()
        {
            return Math.PI * r * r;
        }
    }
}
