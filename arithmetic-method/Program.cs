using System;

class Program
{
    static void Main(string[] args)
    {
        int v1;
        Display();

        Console.WriteLine("Enter a value to find power of 2:");
        v1 = int.Parse(Console.ReadLine());
        Power2(10);
        Power2(v1);

        double pie;
        pie = GetPi();
        Console.WriteLine(pie);

        Console.WriteLine("GetPi second time : {0}", GetPi());

    }
    static double GetPi()
    {
        double p = 3.142;
        return p;

    }

    static void Display()
    {
        Console.WriteLine("Welcome to C# Programming");
        Console.WriteLine("I hope you enjoy the class");
    }

    static void Power2(int n1)
    {
        int answer = n1 * n1;
        Console.WriteLine($"The power of 2 value: {answer}");
    }
}










