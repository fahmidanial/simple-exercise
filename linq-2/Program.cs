using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Lnum = new List<int>();

        Lnum.Add(10);
        Lnum.Add(20);
        Lnum.Add(30);
        Lnum.Add(40);

        Lnum.Insert(0, 5);
        Lnum.Insert(2, 25);

        foreach (int i in Lnum)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        for (int i = 0; i < Lnum.Count; i++)
        {
            Console.Write(Lnum[i] + " ");
        }

        Console.WriteLine();


        List<int> Linteger = new List<int>() { 111, 222, 333, 444, 555, 666, 111, 777, 888 };
        Linteger.Add(999);  // Linteger ->111, 222, 333, 444, 555, 666, 111, 777, 888, 999
        Linteger.Insert(0, 88); // Linteger -> 88, 111, 222, 333, 444, 555, 666, 111, 777, 888, 999
        Linteger.RemoveAt(4); // Linteger -> 88, 111, 222, 333, 555, 666, 111, 777, 888, 999
        Linteger.Remove(111); // Remove the first occurence Linteger -> 88, 222, 333, 555, 666, 111, 777, 888, 999

        Console.WriteLine("Values in Linteger :");
        foreach (int i in Linteger)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

    }
}





