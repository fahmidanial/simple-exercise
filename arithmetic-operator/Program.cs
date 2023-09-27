using System;

class Program
{
    static void Main()
    {
        int n1, n2;
        double answer;
        Console.WriteLine("Enter value 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value 2: ");
        n2 = int.Parse(Console.ReadLine());

        answer = n1 / n2;

        Console.WriteLine("The division outcome: {0}", answer);

    }
}
