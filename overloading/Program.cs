using System;

class Program
{
    static void Main(string[] args)
    {
        int ans1;
        double ans2;

        ans1 = power2(3);  //L1  ==> power2 , passing the value 3 (integer type)
        ans2 = power2(12.8);  //L2 ==> power2, passing the value 12.8 (double type)

        Console.WriteLine($"Power of 2 for integer: {ans1}");
        Console.WriteLine($"Power of 2 for double: {ans2}");


    }

    static int power2(int n1)
    {
        return (n1 * n1);
    }

    static double power2(double n2)
    {
        return (n2 * n2);
    }
}