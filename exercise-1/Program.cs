using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that prompts user to enter 3 integer values. Create a method that is able
        // to find the largest number based on the 3 integer values. Display the largest number. 

        int v1, v2, v3;
        Console.WriteLine("Enter value 1 for finding largest : ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value 2 for finding largest : ");
        v2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value 3 for finding largest : ");
        v3 = int.Parse(Console.ReadLine());

        int large = FindLargest(v1, v2, v3);
        Console.WriteLine($"The largest number:{large}");


    }
    static int FindLargest(int n1, int n2, int n3)
    {
        int largest = n1;
        if (n2 >= n1)
            largest = n2;
        if (n3 >= largest)
            largest = n3;

        return largest;

    }
}