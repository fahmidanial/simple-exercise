using System;

class Program
{
    static void Main(string[] args)
    {

        int num1 = 8;

        Power2(ref num1);
        Console.WriteLine("The power of 2 for num1 is : {0}", num1);


    }
    static void Power2(ref int val)
    {
        val = val * val;
    }


}










