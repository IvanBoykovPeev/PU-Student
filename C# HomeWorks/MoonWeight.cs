using System;

    class MoonWeight
    {
        static void Main(string[] args)
        {
            double earthWeigth = double.Parse(Console.ReadLine());
            double moonWeight = earthWeigth * 0.17;
            Console.WriteLine(moonWeight);
        }
    }

