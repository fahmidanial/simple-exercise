using System;
using System.Xml;


class Program
{
    static void Main(string[] args)
    {


        // formating of numeric valuaces
        double value = 2500.00;

        Console.WriteLine("Value with G: {0:G}", value); //General
        Console.WriteLine("Value with F: {0:F}", value); //Fixed Point
        Console.WriteLine("Value with N: {0:N}", value);//Number with comma separated thousands
        Console.WriteLine("Value with C: {0:C}", value); // To represent currency
        Console.WriteLine("Value with P: {0:P}", value / 1000); //To represent percentage
        Console.WriteLine("Value with 00.000: {0:00.000}", value); //To determine precesion point and zero padding
        Console.WriteLine("Value with 00.000: {0:00000.0000}", value); //To determine precesion point and zero padding 

        Console.ReadKey();

    }
}

