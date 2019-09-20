using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCounter
{
    abstract class Shape
    {
        protected double basewidth;
        protected double baseheight;

        protected Shape(double width, double height)
        {
            this.baseheight = height;
            this.basewidth = width;
        }

        public abstract double Area();

        public abstract double Circumference();
    }
}
