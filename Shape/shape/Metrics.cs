namespace Shape
{
    internal class Metrics
    {
        public double Area { get; }
        public double Perimeter { get; }

        public Metrics(double area, double perimeter)
        {
            Area = area;
            Perimeter = perimeter;
        }
    }
}
