using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterFromFive
{
    class GreaterFromFive
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal greaterNumber = Math.Max(firstNumber, secondNumber);
            decimal thirdNumber = decimal.Parse(Console.ReadLine());
            greaterNumber = Math.Max(thirdNumber, greaterNumber);
            decimal fourtNumber = decimal.Parse(Console.ReadLine());
            greaterNumber = Math.Max(fourtNumber, greaterNumber);
            decimal fifthNumber = decimal.Parse(Console.ReadLine());
            greaterNumber = Math.Max(fifthNumber, greaterNumber);
            Console.WriteLine(greaterNumber);

            Console.ReadKey();
        }
    }
}
