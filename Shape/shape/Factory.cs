namespace Shape
{
    internal class Factory
    {
        public Circle MakeCircle(double radius)
        {
            var circle = new Circle(radius);
            return circle;
        }
        public Rectangle MakeRectangle(double width, double height)
        {
            var rectangle = new Rectangle(width, height);
            return rectangle;
        }
    }
}
