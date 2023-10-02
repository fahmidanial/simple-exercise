using System;

class Program
{
            static void Main(string[] args) {


            int n1 = 10, n2 = 50;

            multiply(n1, n2);
            Console.WriteLine(n2);
            Console.ReadLine();
            

        }
        static void multiply (int n1 , int n2)
        {
            Console.WriteLine($"The multiplication value: {n1 * n2}");
            n2 = 80;
        }


}










