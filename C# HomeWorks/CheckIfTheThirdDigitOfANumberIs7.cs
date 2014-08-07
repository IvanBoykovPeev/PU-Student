using System;

class CheckIfTheThirdDigitOfANumberIs7
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(((number / 100) % 10) == 7);
        }
    }

