using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.BadCode
{
    class Circle
    {
        private int v;

        public Circle(int v)
        {
            Radius = v;
        }

        public double Radius { get; set; }
    }
}
