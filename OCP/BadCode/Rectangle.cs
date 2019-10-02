using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.BadCode
{
    class Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
