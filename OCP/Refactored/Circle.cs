using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Refactored
{
    class Circle : Shape
    {
        public Circle(int v)
        {
            Radius = v;
        }

        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
