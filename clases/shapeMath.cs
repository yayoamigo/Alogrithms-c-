using System;

namespace classes
{
    class ShapeMath
    {
        public static double GetArea(string shape = "", double lenght1 = 0, double lenght2 = 0) {

            if (string.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 0;

            } else if (string.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            } else
            {
                return 3;
            }

        }
    }
}