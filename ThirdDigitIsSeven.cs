using System;

    class ThirdDigitIsSeven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool check = false;

            if ((number / 100) % 10 == 7)
            {
                check = true;
            }
            Console.WriteLine(check);

        }
    }

