using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Trapezoids
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The Area is: {0}", area);

        }
    }

