namespace Shape
{
    internal abstract class Shape
    {
        protected abstract double Area();
        protected abstract double Perimeter();

        public Metrics Calculate()
        {
            var area = Area();
            var perimeter = Perimeter();
            var output = new Metrics(area, perimeter);

            return output;

        }
    }
}
