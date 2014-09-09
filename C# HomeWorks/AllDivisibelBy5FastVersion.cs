using System;

namespace AllDivisibelBy5FastVersion
{
    class AllDivisibelBy5FastVersion
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            //How many numbers have divisor by 5
            int numberOfRange = (secondNumber / 5) - (firstNumber / 5);
            if (firstNumber % 5 == 0)
            {
                numberOfRange++;
            }
            Console.WriteLine(numberOfRange);

            Console.ReadKey();
        }
    }
}
