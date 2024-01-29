//Amir Jaraysa CPS 3330-01 Lab 2

using static System.Runtime.InteropServices.JavaScript.JSType;
using MaximumLibrary;

class MaxTest 
{
    static void Main ()
    {
        Console.WriteLine("Are you entering 2 or 3 numbers to be compared?: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the first number and press enter: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number and press enter: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (x == 3)
        {
            Console.WriteLine("Enter the third number and press enter: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double maxNumber = MaxClass.MaxNumber(a, b, c);
            Console.WriteLine($"The maximum of {a}, {b} and {c} is {maxNumber}");
        }
        else
        {
            double maxNumber = MaxClass.MaxNumber(a, b);
            Console.WriteLine($"The maximum of {a} and {b} is {maxNumber}");

        }

        Console.ReadLine();
    }
}