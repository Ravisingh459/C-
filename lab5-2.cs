using System;

class Program
{
    static void Main(string[] args)
    {
        double radius, area;

        Console.Write("Enter radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        // Formula: Area = π × r × r
        area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}