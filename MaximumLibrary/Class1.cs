//Amir Jaraysa CPS 3330-01 Lab 2

namespace MaximumLibrary
{
    public class MaxClass
    {
        public static double MaxNumber(double a, double b)
        {
            return Math.Max(a, b);
        }
        public static double MaxNumber(double a, double b, double c)
        {
            double x = Math.Max(a, b);
            return Math.Max(x, c);
        }
    }
}
