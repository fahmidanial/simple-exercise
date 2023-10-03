using System;

class Program
{
    static void Main(string[] args)
    {


        try
        {
            int n;
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter which index of the array you want to display: ");
            n = int.Parse(Console.ReadLine()); //formatexception aa

            Console.WriteLine(arr[n]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Bye bye");
        }
    }


}



























