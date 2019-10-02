using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.Refactored
{
    class Rectangle : Shape
    {
        public Rectangle(int v1, int v2)
        {
            Width = v1;
            Height = v2;
        }

        public double  Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
