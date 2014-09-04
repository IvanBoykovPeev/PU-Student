using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThreeInt
{
    class ReadThreeInt
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int firstNumber = int.Parse(inputString);
            inputString = Console.ReadLine();
            int secondNumber = int.Parse(inputString);
            inputString = Console.ReadLine();
            int thirdNumber = int.Parse(inputString);
            long sum = (long)firstNumber + secondNumber + thirdNumber;
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
