using System;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        do
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
                flag = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the right format");
                flag = false;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please ensure value 2 is not zero");
                flag = false;
            }
        } while (!flag);
    }

}



























