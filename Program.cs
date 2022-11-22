using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace opertatorss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a/b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var r = 20;
            var pi = Math.PI;

            Console.WriteLine($"What is the radius of your circle");
            double realRadius ;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);
            
            var areaOfCircle = CalculateArea(20);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

            

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius* radius);
        }
    }
}
