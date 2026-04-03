using System;

class Program
{
    static void Main()
    {
        int age;

        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("You are a Kid");
        }
        else if (age >= 12 && age <= 17)
        {
            Console.WriteLine("You are a Teenager");
        }
        else if (age >= 18 && age <= 60)
        {
            Console.WriteLine("You are an Adult");
        }
        else if (age > 60)
        {
            Console.WriteLine("You are a Senior Citizen");
        }
    }
}