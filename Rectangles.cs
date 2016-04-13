using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Height");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (width * 2) + (height * 2);
        double area = width * height;

        Console.WriteLine("Perimeter is: {0}\nArea is: {1}", perimeter, area);
    }
}

