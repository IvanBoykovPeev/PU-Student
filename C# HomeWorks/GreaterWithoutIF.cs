using System;
 class GreaterWithoutIF
    {
        static void Main(string[] args)
        {
            decimal firsNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal greaterNumber = Math.Max(firsNumber, secondNumber);
            Console.WriteLine(greaterNumber);

            Console.ReadKey();
        }
    }
