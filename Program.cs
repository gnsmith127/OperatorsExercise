using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var calculateArea = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {calculateArea}.");

        }

        public static double AreaOfCircle(double radius)
        {
            
            return Math.PI * radius * radius;
            
        }
    }
}
