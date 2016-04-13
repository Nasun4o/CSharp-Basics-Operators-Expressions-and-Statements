using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ModifyBitPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());
            int mask, result;
            if (value == 1)
            {
                mask = 1 << p;
                result = n | mask;
            }
            else
            {
                mask = ~(1 << p);
                result = n & mask;
            }
            
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(16, '0'));
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));

        }
    }
