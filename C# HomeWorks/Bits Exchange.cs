using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public class BitManipulations
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long b = getBitAtPosition(number, 3);
            long b1 = getBitAtPosition(number, 4);
            long b2 = getBitAtPosition(number, 5);
            long b3 = getBitAtPosition(number, 24);
            long b4 = getBitAtPosition(number, 25);
            long b5 = getBitAtPosition(number, 26);
            number = setBitAtPosition(number, b, 24);
            number = setBitAtPosition(number, b1, 25);
            number = setBitAtPosition(number, b2, 26);
            number = setBitAtPosition(number, b3, 3);
            number = setBitAtPosition(number, b4, 4);
            number = setBitAtPosition(number, b5, 5);
            Console.WriteLine(number);
            

        }
        public static long getBitAtPosition(long number, int position)
        {
            number = number >> position;
            long bit = number & 1;            
            return bit;
        }

        public static long setBitAtPosition(long number, long bit, int position)
        {

            
            if (bit == 1)
            {
                long mask = 1 << position;
                long result = number | mask;               
                return result;
            }
            
            else
            {
                long mask = 1 << position;
                number = mask | number;
                long result = mask ^ number; 
                return result;
            }
            
        }
    }
}