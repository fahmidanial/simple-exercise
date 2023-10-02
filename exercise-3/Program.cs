using System;

class Program
{
    static void Main(string[] args)
    {

        //Create an array(Name: arr1) and initialize it with the following values: 55, 66, 77, 88, 99
        //Create another array(Name: arr2) with size of 5.Prompt users to enter the values for the array .
        //Calculate the total of the values for both array and display your result accordingly.

        int[] arr1 = new int[] { 55, 66, 77, 88, 99 };  // created array with the stated values

        double[] arr2 = new double[5];  //created an array to store double values. the size is 5

        for (int i = 0; i < arr2.Length; i++) // i : 0 -> 4
        {
            Console.WriteLine("Enter a double value : ");
            arr2[i] = double.Parse(Console.ReadLine()); //store inside the value according to the index

        }

        int total = 0;
        for (int cnt = 0; cnt < arr1.Length; cnt++)
        {
            total = total + arr1[cnt];
        }
        Console.WriteLine($"The total value of arr1 : {total}");

        double dtotal = 0.0;

        foreach (double v in arr2)
        {
            dtotal = dtotal + v;
        }
        Console.WriteLine($"The total value of arr2 : {dtotal}");

    }
}











