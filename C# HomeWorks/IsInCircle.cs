using System;

class IsInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 5;

            bool inTheCircle = ((x * x + y * y) < radius * radius);
            Console.WriteLine(inTheCircle);
        }
    }

