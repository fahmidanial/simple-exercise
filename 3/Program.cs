using System;

class Program
{

    static void Main(string[] args)
    {
        double d1, d2, d3;
        Console.WriteLine("Enter income for Day1: ");
        d1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter income for Day2: ");
        d2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter income for Day3: ");
        d3 = double.Parse(Console.ReadLine());

        double answer;
        answer = Add3days(d1, d2, d3);
        Console.WriteLine($"The total income for 3 days: {answer}");

        answer = Add3days(day3: d3, day2: d2, day1: d1);
        Console.WriteLine($"The total income for 3 days: {answer}");

        answer = Add3days(d1, day3: d3, day2: d2);
        Console.WriteLine($"The total income for 3 days: {answer}");

    }

    static double Add3days(double day1, double day2, double day3)
    {
        return (day1 + day2 + day3);
    }


}













