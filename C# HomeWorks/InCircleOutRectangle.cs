using System;

 class InCircleOutRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 5;

            bool isInTheCircle = (x * x + y * y) < radius * radius;
            bool isInTheRectangle = (x > -1 && x < 5 && y > 1 && y < 5);

            Console.WriteLine(isInTheCircle && isInTheRectangle);
        }
    }

