//using SOLID.OCP.BadCode;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ocp
            Console.WriteLine("Hello World!\n");

            //bad code
            var square = new OCP.BadCode.Rectangle(2, 2);
            var rectangle = new OCP.BadCode.Rectangle(2, 3);
            var circle = new OCP.BadCode.Circle(5);
            var areaCalculator = new OCP.BadCode.AreaCalculator();
            var area = areaCalculator.Area(new object[] { square, rectangle, circle });

            Console.WriteLine("Area: " + area);

            //refactor
            var rectangle1 = new OCP.Refactored.Rectangle(2, 3);
            var circle1 = new OCP.Refactored.Circle(4);

            var areaCalculator1 = new OCP.Refactored.AreaCalculator();
            var area1 = areaCalculator1.Area(new OCP.Refactored.Shape[] { rectangle1, circle1 });

            Console.WriteLine("Area: " + area1);
            #endregion

            #region lsp

            #endregion
        }
    }
}
