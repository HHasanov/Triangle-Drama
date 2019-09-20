using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCounter
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double Area()
        {
            return (basewidth * baseheight) / 2;
        }

        public override double Circumference()
        {
            double hyp = Math.Sqrt(basewidth * basewidth + baseheight * baseheight);
            return hyp + baseheight + basewidth;
        }
    }
}
