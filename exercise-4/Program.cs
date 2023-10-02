using System;

class Program
{
    static void Main(string[] args)
    {

        //Replacing odd number of integer array with - 111.Given array values: 2,5,8,9,10,6,9
        //Displaying the reverse order of an array 9, 5, 12, 1, 3 ,6, 4
        //Copying the array content to another array

           int[] arr = new int[] { 2, 5, 8, 9, 10, 6, 9 };
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] % 2) == 1)
            {
                arr[i] = -111;
            }
        }
        foreach (int v in arr)
            Console.WriteLine(v);

    }
}











