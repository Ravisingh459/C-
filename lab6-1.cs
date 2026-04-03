using System;

class Program
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter radius: ");
        radius = double.Parse(Console.ReadLine());

        area = Math.PI * radius * radius;

        Console.WriteLine("Area of circle = " + area);
    }
}