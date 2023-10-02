using System;

class Program
{
    static void Main(string[] args)
    {
        int iv1 = 111;
        double dv2 = 12.8989;
        F1(iv1, dv2);
        F1(n2: dv2, n1: iv1);  //named parameter
    }

    static void F1(int n1, double n2)
    {
        Console.WriteLine($"Integer value passed to method : {n1}");

        Console.WriteLine($"Double value passed to method : {n1}");
    }
}













