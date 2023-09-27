using System;

class Program
{
    static void Main(string[] args)
    {
        Display();

        Power2(10);

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







