using System;

class Program
{
    static void Main(string[] args)
    {

        Display();
        Console.WriteLine("Pi value is : {0}", GetPi());
        int n1 = 5, n2 = 11;
        int answer = Multiply(n1, n2);
    }
    //static void Display ()
    //{
    //    Console.WriteLine("Welcome to C# programming !");
    //}

    static void Display() => Console.WriteLine("Welcome to C# programming !");

    //static double GetPi()
    //{
    //    return 3.142;
    //}

    static double GetPi() => 3.142;
    static int Multiply(int n1, int n2) => n1 * n2;




}











