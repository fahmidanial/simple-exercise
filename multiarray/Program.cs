using System;

class Program
{
    static void Main(string[] args)
    {

        int[,] marr;
        marr = new int[2, 3];

        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine("Enter the value for multi dimensional array:");
                marr[r, c] = int.Parse(Console.ReadLine());
            }
        }


        for (int r = 0; r < marr.GetLength(0); r++)
            for (int c = 0; c < marr.GetLength(1); c++)
                Console.WriteLine(marr[r, c]);


    }
}











