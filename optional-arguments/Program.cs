using System;

class Program
{
    static void Main(string[] args)
    {
        Add(1, 2, 3);
        Add(1);
        Add(1, 2);
        Add();
        Console.ReadLine();

    }

    static void Add(int n1 = 10, int n2 = 20, int n3 = 30)
    {
        int total = n1 + n2 + n3;
        Console.WriteLine($"The total of {n1} + {n2} + {n3} = {total}");
    }
}







