using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is Even.", number);
        }
        else
        {
            Console.WriteLine("{0} is Odd.", number);
        }

    }
}
