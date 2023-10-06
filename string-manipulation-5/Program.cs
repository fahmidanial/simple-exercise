using System;


class Program
{
    static void Main(string[] args)
    {
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        string str = "HelloHelloyoHowareyou";  //string type with the values assigned
        char[] chr = { 'h', 'l', 'P' };


        Console.WriteLine("LastIndexof 'c'");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"Length : {str.Length}"); //-> 21
        Console.WriteLine($"{str.LastIndexOf('o')}"); //->from behind of the string first of occurence of o ->19
        Console.WriteLine($"{str.LastIndexOf('o', 18)}"); // from 0, 18 behind direction -> 13
        Console.WriteLine($"{str.LastIndexOf('H', 6, 3)}"); // 3 positions ending at 6 -> 4 ,5 6,  ->5
        Console.WriteLine("");

        Console.WriteLine("Indexof 'c'");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOf('e')}"); //first occurence of e from front -> 1
        Console.WriteLine($"{str.IndexOf('e', 2)}"); //position 2 onwards -> 6
        Console.WriteLine($"{str.IndexOf('e', 3, 2)}");//starting at 3 -> 2 positions (3, 4)  -> -1
        Console.WriteLine("");

        Console.WriteLine("Indexof String");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOf("Hello")}");  //From front find the Hello -> 0
        Console.WriteLine($"{str.IndexOf("Hello", 2)}"); //From 2 onwards find Hello -> 5
        Console.WriteLine($"{str.IndexOf("Hello", 2, 5)}"); //starting at 2-> 5 positions(2 -> 6)-> -1
        Console.WriteLine("");

        Console.WriteLine("LastIndexof String");
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.LastIndexOf("Hello")}"); //from  behind find "Hello" -> 5
        Console.WriteLine($"{str.LastIndexOf("Hello", 4)}"); //up to 4 -> from 0 up to 4 -> 0
        Console.WriteLine($"{str.LastIndexOf("Hello", 4, 5)}"); //5 positions ending at 4 -> 4 3 2 1 0 ->0
        Console.WriteLine("");

        Console.WriteLine("IndexofAny String");
        //chr h l p 
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
        Console.WriteLine($"{str.IndexOfAny(chr)}"); // first occurence of h l or p from front -> 2
        Console.WriteLine($"{str.IndexOfAny(chr, 10)}"); //position 10 onwards find h l or p -> -1
        Console.WriteLine("");

        Console.WriteLine("LastIndexofAny String");
        //chr h l p 
        //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u

        Console.WriteLine($"{str.LastIndexOfAny(chr)}"); // From behind the first occurence of h l or p -> 8
        Console.WriteLine($"{str.LastIndexOfAny(chr, 7)}"); //starting 0 to 7 (up to 7) -> 7

        Console.WriteLine("\n");

    }
}

