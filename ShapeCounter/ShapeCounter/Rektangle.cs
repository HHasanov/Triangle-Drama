using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCounter
{
    class Rektangle : Shape
    {
        public Rektangle(double width, double height) : base(width, height) { }

        public override double Area()
        {
            return basewidth * baseheight;
        }

        public override double Circumference()
        {
            return (basewidth * 2) + (baseheight * 2);
        }
    }
}

