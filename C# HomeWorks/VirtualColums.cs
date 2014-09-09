using System;

namespace VirtualColums
{
    class VirtualColums
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int firstNum = int.Parse(input);
            input = Console.ReadLine();
            double secondNum = double.Parse(input);
            input = Console.ReadLine();
            double thirdNum = double.Parse(input);
            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}",
                firstNum, secondNum, thirdNum);

            Console.ReadKey();
        }
    }
}
