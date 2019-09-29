namespace Shape
{
    internal class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        protected override double Area()
        {
            var area = _width * _height;
            return area;
        }

        protected override double Perimeter()
        {
            var perimeter = _width + _height + _width + _height;
            return perimeter;
        }
    }
}
