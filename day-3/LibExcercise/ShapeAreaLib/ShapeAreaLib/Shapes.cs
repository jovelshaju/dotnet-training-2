using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Rectangle
    {
        public double Area(double length, double breadth)
        {
            double result = length * breadth;
            return result;
        }

    }
    public class Square
    {
        public double Area(double length)
        {
            double result = length * length;
            return result;
        }

    }
    public class Circle
    {
        public double Area(double radius)
        {
            double result = 3.14 * radius * radius;
            return result;
        }

    }
    public class Triangle
    {
        public double Area(double height, double breadth)
        {
            double result = 0.5 * height * breadth;
            return result;
        }

    }
}
