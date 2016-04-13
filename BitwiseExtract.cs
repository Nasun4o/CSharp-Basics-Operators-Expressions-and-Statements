using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class BitwiseExtract
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int numbRight = number << 3;
            int bit = numbRight & 1;

            Console.WriteLine(bit);
        }
    }