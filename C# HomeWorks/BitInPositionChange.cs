using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitInPositionChange
{
    class BitInPositionChange
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int mask = v << bitPosition;

            inputNumber = inputNumber & (~(1 << bitPosition));
            int result = inputNumber | mask;

            Console.WriteLine(result);

            Console.ReadKey();
             
        }
    }
}
