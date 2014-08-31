using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class IsPrimeNumber
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int devisor = 2; devisor < Math.Sqrt(number); devisor++)
            {
                if (number % devisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime);

            Console.ReadKey();
        }
    }
}
