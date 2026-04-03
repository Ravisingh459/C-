using System;

class Program
{
    static void Main(string[] args)
    {
        double principal, rate, time, amount, compoundInterest;

        Console.Write("Enter Principal Amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = Convert.ToDouble(Console.ReadLine());

        // Formula: A = P * (1 + R/100)^T
        amount = principal * Math.Pow((1 + rate / 100), time);

        // Compound Interest = Amount - Principal
        compoundInterest = amount - principal;

        Console.WriteLine("Compound Interest = " + compoundInterest);
    }
}