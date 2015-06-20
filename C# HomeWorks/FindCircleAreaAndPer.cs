using System;

namespace FindCircleAreaAndPerimeter
{
    class FindCircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            byte radius = byte.Parse(inputString);
            double perimeter = 2 * radius * Math.PI;
            double area = radius * radius * Math.PI;
            Console.WriteLine("{0:F3}", perimeter);
            Console.WriteLine("{0:F3}", area);

            Console.ReadKey();
        }
    }
}
