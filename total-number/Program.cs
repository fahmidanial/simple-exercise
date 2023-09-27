using System;

class Program
{
    static void Main()
    {
        //write a program to get two inputs of numbers from the user. calculate the total.

        //string input1, input2;
        //Console.WriteLine("Enter value 1:");
        //input1 = Console.ReadLine();   //input1:11
        //Console.WriteLine("Enter value 2:");
        //input2 = Console.ReadLine(); //input2:22

        //string total;
        //total = input1 + input2; //input1:11 and input2:22 -> 1122
        //Console.WriteLine("The total of the two values : {0}", total);

        //int n1, n2;

        //n1 = Convert.ToInt32(input1);  //convert the string input 1type value to integer type value

        //n2 = int.Parse(input2);  //convert the string input2 type into integer type value

        //int total = n1 + n2;
        //Console.WriteLine("The total of the two values : {0}", total);


        //Console.WriteLine("The total of the two values : {0}", n1+n2);


        int n1, n2, total;
        Console.WriteLine("Enter value 1:");
        n1 = int.Parse(Console.ReadLine()); //input:11
        Console.WriteLine("Enter value 2:");
        n2 = Convert.ToInt32(Console.ReadLine()); //input2:22
        total = n1 + n2;
        Console.WriteLine("The total of the two values : {0}", total);

    }
}
