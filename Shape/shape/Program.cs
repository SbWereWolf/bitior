using System;

namespace Shape
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var handler = new Handler(input);

            var isSuccess = handler.Process();
            if (isSuccess && handler.Metrics != null)
            {
                Console.WriteLine($@"
Area: {handler.Metrics.Area}; Perimeter: {handler.Metrics.Perimeter}
");
            }
            if (!isSuccess)
            {

                Console.WriteLine(@"
Please use proper format : 
   Circle:Radius
OR Rectangle:WidthxHeght

Radius, Width, Heght - MUST BE number
");
            }
        }
    }
}
