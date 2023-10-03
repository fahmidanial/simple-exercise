using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n1, n2;
            double answer;
            Console.WriteLine("Enter value 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine()); // integer value 12 , but key aa 

            Console.WriteLine("Enter value 2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            answer = n1 / n2;
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Enter the right format");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please ensure value 2 is not zero");

        }

    }

}













