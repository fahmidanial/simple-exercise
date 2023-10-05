using System;


class Program
{
    static void Main(string[] args)
    {
        char[] arrCH = new char[] { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' }; //an array of char
        string str = "Hello , how are you?";



        string str2 = new string(arrCH);
        string str3 = new string(arrCH, 6, 3);
        string str4 = new string('%', 5);

        Console.WriteLine($"arrCH : {arrCH}");
        Console.WriteLine(arrCH);
        Console.WriteLine($"str: {str}");
        Console.WriteLine($"str2: {str2}");
        Console.WriteLine($"str3: {str3}");
        Console.WriteLine($"str4: {str4}");





    }
}

