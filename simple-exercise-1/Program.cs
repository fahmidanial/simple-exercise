using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize a character type
            //Declare and initialize an integer type
            //Declare and initialize a float type
            // Declare and initialize a double type
            //Declare and initialize a decimal type
            //Declare and initialize a boolean type
            //Declare and initialize a string type
            //There are data type suffixes given below.
            //L or l for long
            //(l in small letters should be avoided as it confuses you with digit 1)
            //D or d for double
            //F or f for float
            //M or m for decimal
            //(D is already taken for double, so M is best representation for decimal)
            // U or u for unsigned integer
            //UL or ul for unsigned lon


            char ch = 'T';
            int n1 = 88;
            float fl = 1.99998F;
            double db = 2.99999998;
            decimal dc = 3.99999999999999m;
            bool flag = true;
            string name = "David Johson";

            Console.WriteLine("ch: " + ch);
            Console.WriteLine("n1: {0}", n1);
            Console.WriteLine("fl: {0}", fl);
            Console.WriteLine("db: {0}", db);
            Console.WriteLine("dc: {0}", dc);
            Console.WriteLine("flag: {0}", flag);
            Console.WriteLine("name: {0}", name);
        }
    }
}