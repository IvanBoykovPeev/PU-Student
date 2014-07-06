using System;

namespace HomeWorks
{
    class My10YearAfter
    {
        static void Main(string[] args)
        {
            //Write a program that reads your age from the console and
            //prints your age after 10 years.
            int age;
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            bool isTrue = Int32.TryParse(input,out age);
            if (isTrue)
            {
                if (age <= 0 || age > 120)
                {
                    Console.WriteLine("Invalid data");
                }
                else
                {
                    Console.WriteLine(age + 10);
                }
            }
            else
            {
                Console.WriteLine("Invalid data");    
            }
            Console.ReadKey();
        }
    }
}
