using System;
using System.Collections.Generic;
using System.Globalization;

namespace Shape
{
    internal class Handler
    {
        private readonly string _input;
        public Metrics Metrics { get; private set; }

        public Handler(string input)
        {
            _input = input;
            Metrics = null;
        }
        public bool Process()
        {
            var command = _input?.Split(':', StringSplitOptions.RemoveEmptyEntries);

            var isSuccess = command != null;
            if (isSuccess)
            {
                isSuccess = command.Length == 2;
            }
            var type = String.Empty;
            const string circle = "circle";
            const string rectangle = "rectangle";
            if (isSuccess)
            {
                type = command[0]?.ToLowerInvariant();
                isSuccess = type != circle || type != rectangle;
            }
            Shape shape = null;
            if (isSuccess)
            {
                switch (type)
                {
                    case circle:
                        isSuccess = ValidateCircle(command, out var radius);
                        if (isSuccess)
                        {
                            shape = new Factory().MakeCircle(radius);
                        }
                        break;
                    case rectangle:
                        isSuccess = ValidateRectangle(command, out var width, out var height);
                        if (isSuccess)
                        {
                            shape = new Factory().MakeRectangle(width, height);
                        }
                        break;
                }
                isSuccess = shape != null;
            }
            if (isSuccess)
            {
                Metrics = shape.Calculate();
                isSuccess = Metrics != null;
            }

            return isSuccess;
        }


        private static bool ValidateCircle(string[] command, out double radius)
        {
            var isSuccess = false;
            radius = 0;
            if (command?[1] != null)
            {
                isSuccess = double.TryParse(command[1], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture,
                    out radius);
            }
            return isSuccess;
        }

        private static bool ValidateRectangle(IReadOnlyList<string> command, out double width, out double height)
        {
            var isSuccess = false;
            var sizes = new string[0];
            if (command?[1] != null)
            {
                sizes = command[1].Split('x', StringSplitOptions.RemoveEmptyEntries);
                isSuccess = sizes != null;
            }
            if (isSuccess)
            {
                isSuccess = sizes.Length == 2;
            }
            width = 0.0;
            if (isSuccess)
            {
                isSuccess = double.TryParse(sizes[0], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture,
                    out width);
            }
            height = 0.0;
            if (isSuccess)
            {
                isSuccess = double.TryParse(sizes[1], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture,
                    out height);
            }
            return isSuccess;
        }
    }
}
