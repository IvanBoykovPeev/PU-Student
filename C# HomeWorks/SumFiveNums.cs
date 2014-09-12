using System;

namespace SumFiveNums
{
    class SumFiveNums
    {
        static void Main(string[] args)
        {
            string inputLine = string.Empty;
            int firstNum = 0;
            bool isNumberCorect = false;
            while (!isNumberCorect)
            {
                inputLine = Console.ReadLine();
                isNumberCorect = int.TryParse(inputLine, out firstNum);
            }

            int secondNumber = 0;
            isNumberCorect = false;
            while (!isNumberCorect)
            {
                inputLine = Console.ReadLine();
                isNumberCorect = int.TryParse(inputLine, out secondNumber);
            }

            int thirdNumber = 0;
            isNumberCorect = false;
            while (!isNumberCorect)
            {
                inputLine = Console.ReadLine();
                isNumberCorect = int.TryParse(inputLine, out thirdNumber);
            }

            int fourtNumber = 0;
            isNumberCorect = false;
            while (!isNumberCorect)
            {
                inputLine = Console.ReadLine();
                isNumberCorect = int.TryParse(inputLine, out fourtNumber);
            }

            int fifthNumber = 0;
            isNumberCorect = false;
            while (!isNumberCorect)
            {
                inputLine = Console.ReadLine();
                isNumberCorect = int.TryParse(inputLine, out fifthNumber); 
            }

            long sun = (long)firstNum + secondNumber + thirdNumber +
                fourtNumber + fifthNumber;
            Console.WriteLine(sun);

            Console.ReadKey();
        }
    }
}
