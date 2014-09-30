using System;

namespace CircleApp
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetDiameter()
        {
            return 2*radius;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radius;
        }

        public double GetArea()
        {
            return Math.PI*radius*radius;
        }
    }
}
