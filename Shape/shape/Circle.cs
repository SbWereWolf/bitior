using System;

namespace Shape
{
    class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        protected override double Area()
        {
            var area = Math.Pow(_radius, 2) * Math.PI;
            return area;
        }

        protected override double Perimeter()
        {
            var perimeter = _radius * 2 * Math.PI;
            return perimeter;
        }
    }
}
