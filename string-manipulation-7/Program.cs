using System;


class Program
{
    static void Main(string[] args)
    {
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        string str = "HelloHelloyoHowareyou";



        // invoke Substring method and pass it one parameter
        Console.WriteLine("Substring from index 10 to end is " +
           $"\"{str.Substring(10)}\"");

        // invoke Substring method and pass it two parameters
        Console.WriteLine("Substring from index 0 of length 5 is " +
           $"\"{str.Substring(0, 5)}\"");


    }
}

