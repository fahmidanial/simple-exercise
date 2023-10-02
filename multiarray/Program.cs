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


        //int[][] jarr = new int[3][];

        //jarr[0] = new int[] { 1, 2, 3 };
        //jarr[1] = new int[] { 4 };
        //jarr[2] = new int[] { 5, 6 };

        //int[][] jarr2 = new int[3][] { new int[] { 2, 4 }, new int[] { 5, 6, 7 }, new int[] { 9 } };

        //foreach (var rows in jarr)
        //    foreach (var v in rows)
        //        Console.WriteLine(v);


        //for (int r = 0; r < jarr2.GetLength(0); r++)
        //{
        //    for (int c = 0; c < jarr2[r].Length; c++)
        //        Console.Write(jarr2[r][c] + " ");

        //    Console.WriteLine(" ");

        //}



    }
}











