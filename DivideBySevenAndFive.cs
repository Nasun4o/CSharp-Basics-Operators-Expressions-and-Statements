using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool check = false;

        if (number % 7 == 0 && number % 5 == 0)
        {
            check = true;
        }
        Console.WriteLine(check);
    }
}

