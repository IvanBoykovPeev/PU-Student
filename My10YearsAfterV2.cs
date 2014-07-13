using System;

class My10YearsAfterV2
    {
    static void Main()
    {
        int age;
        string ageString;

        ageString = Console.ReadLine();
        try
        {
            age = int.Parse(ageString);
            if (age <= 0 || age > 120)
            {
                throw new OverflowException();
            }
            Console.WriteLine(age + 10);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Age missing.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Not a valid age.");
        }

        Console.ReadKey();
    }
}

