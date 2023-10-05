using System;


class Program
{
    static void Main(string[] args)
    {
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        string str = "HelloHelloyoHowareyou";
        char[] chr = { 'h', 'l', 'P' };

        Console.WriteLine("LastIndexof 'c'");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"Length : {str.Length}"); //-> 
        Console.WriteLine($"{str.LastIndexOf('o')}"); //->
        Console.WriteLine($"{str.LastIndexOf('o', 18)}"); // from 0, 18 behind direction -> 
        Console.WriteLine($"{str.LastIndexOf('H', 6, 3)}"); // 3 positions ending at 6 -> 4 ,5 6, 
        Console.WriteLine("");

        Console.WriteLine("Indexof 'c'");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOf('e')}");
        Console.WriteLine($"{str.IndexOf('e', 2)}"); //position 2 onwards
        Console.WriteLine($"{str.IndexOf('e', 3, 2)}");//starting at 3 -> 2 positions
        Console.WriteLine("");

        Console.WriteLine("Indexof String");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOf("Hello")}");
        Console.WriteLine($"{str.IndexOf("Hello", 2)}"); //From 2 
        Console.WriteLine($"{str.IndexOf("Hello", 2, 5)}"); //starting at 2-> 5 positions
        Console.WriteLine("");

        Console.WriteLine("LastIndexof String");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.LastIndexOf("Hello")}");
        Console.WriteLine($"{str.LastIndexOf("Hello", 4)}"); //up to 4 -> from 0 up to 4
        Console.WriteLine($"{str.LastIndexOf("Hello", 4, 5)}"); //5 positions ending at 4 -> 4 3 2 1 0
        Console.WriteLine("");

        Console.WriteLine("IndexofAny String");
        //chr h l p 
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOfAny(chr)}"); // first occurence of h l or p
        Console.WriteLine($"{str.IndexOfAny(chr, 10)}"); //position 10 onwards
        Console.WriteLine("");

        Console.WriteLine("LastIndexofAny String");
        //chr h l p 
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u

        Console.WriteLine($"{str.LastIndexOfAny(chr)}"); // From behind the first occurence of h l or p
        Console.WriteLine($"{str.LastIndexOfAny(chr, 7)}"); //starting 0 to 7 (up to 7)

        Console.WriteLine("\n");

    }
}

