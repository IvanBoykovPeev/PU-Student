using System;
class Program
{
    static void Main(string[] args)
    {
        short h = short.Parse(Console.ReadLine());

        short x1 = short.Parse(Console.ReadLine());
        short y1 = short.Parse(Console.ReadLine());
        short x2 = short.Parse(Console.ReadLine());
        short y2 = short.Parse(Console.ReadLine());
        short x3 = short.Parse(Console.ReadLine());
        short y3 = short.Parse(Console.ReadLine());
        short x4 = short.Parse(Console.ReadLine());
        short y4 = short.Parse(Console.ReadLine());
        short x5 = short.Parse(Console.ReadLine());
        short y5 = short.Parse(Console.ReadLine());

        if (h > 0)
        {
            if ((x1 >= 0 && x1 <= h * 3 && y1 >= 0 && y1 <= h)
                   || (x1 >= h && x1 <= h * 2 && y1 >= 0 && y1 <= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x2 >= 0 && x2 <= h * 3 && y2 >= 0 && y2 <= h)
                   || (x2 >= h && x2 <= h * 2 && y2 >= 0 && y2 <= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x3 >= 0 && x3 <= h * 3 && y3 >= 0 && y3 <= h)
                   || (x3 >= h && x3 <= h * 2 && y3 >= 0 && y3 <= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x4 >= 0 && x4 <= h * 3 && y4 >= 0 && y4 <= h)
                   || (x4 >= h && x4 <= h * 2 && y4 >= 0 && y4 <= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x5 >= 0 && x5 <= h * 3 && y5 >= 0 && y5 <= h)
                   || (x5 >= h && x5 <= h * 2 && y5 >= 0 && y5 <= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }
        }

        if (h < 0)
        {
            if ((x1 <= 0 && x1 >= h * 3 && y1 <= 0 && y1 >= h)
                   || (x1 <= h && x1 >= h * 2 && y1 <= 0 && y1 >= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x2 <= 0 && x2 >= h * 3 && y2 <= 0 && y2 >= h)
                   || (x2 <= h && x2 >= h * 2 && y2 <= 0 && y2 >= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x3 <= 0 && x3 >= h * 3 && y3 <= 0 && y3 >= h)
                   || (x3 <= h && x3 >= h * 2 && y3 <= 0 && y3 >= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x4 <= 0 && x4 >= h * 3 && y4 <= 0 && y4 >= h)
                   || (x4 <= h && x4 >= h * 2 && y4 <= 0 && y4 >= h * 4))
            {
                Console.WriteLine("inside");
            }

            else
            {
                Console.WriteLine("outside");
            }

            if ((x5 <= 0 && x5 >= h * 3 && y5 <= 0 && y5 >= h)
                   || (x5 <= h && x5 >= h * 2 && y5 <= 0 && y5 >= h * 4))
            {
                Console.WriteLine("inside");
            }
        }

    }
}
