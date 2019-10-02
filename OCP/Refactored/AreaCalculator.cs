namespace SOLID.OCP.Refactored
{
    class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach(var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
