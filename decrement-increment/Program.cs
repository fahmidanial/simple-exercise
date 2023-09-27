using System;

class Program
{
    static void Main()
    {
        int f1 = 70, f2 = 90, total;

        total = f1++ - --f2;

        Console.WriteLine($"total : {total}");



    }
}