using System;

namespace HomeWorks
{
    class OddOrEvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InputNumber");
            //Read number
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number % 2) == 0? "Even" : "Odd");

            Console.ReadKey();
        }
    }
}
