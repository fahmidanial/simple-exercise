using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 23, 11, 15, 8, 200, 7, 88, 65 };
        int[] arr2 = new int[8];

        // Prompt user to enter values into arr2
        Console.WriteLine("Enter 8 values for arr2:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                arr2[i] = value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--; // Retry input for the same index
            }
        }

        // Display arr1 in reverse order
        Console.WriteLine("Reversed arr1:");
        Reverse(arr1);

        // Count even numbers in arr2
        int evenCount = 0;
        foreach (int value in arr2)
        {
            if (isEven(value))
            {
                evenCount++;
            }
        }
        Console.WriteLine($"Number of even elements in arr2: {evenCount}");

        // Compare arr1 and arr2
        bool areArraysEqual = CompareArr(arr1, arr2);
        Console.WriteLine("Are arr1 and arr2 the same? " + (areArraysEqual ? "Yes" : "No"));
    }

    static void Reverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static bool isEven(int num)
    {
        return num % 2 == 0;
    }

    static bool CompareArr(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}
