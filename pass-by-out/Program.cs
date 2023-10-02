using System;

class Program
{
    static void Main(string[] args)
    {

        int val2;

        Power2(out val2);
        Console.WriteLine("The power of 2 for val2 is : {0}", val2);


    }
    static void Power2(out int val)
    {
        val = 9;
        val = val * val;
    }


}

// out is initialize outside tha main vs ref is initialize inside the main










