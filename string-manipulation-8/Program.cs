using System;


class Program
{
    static void Main(string[] args)
    {


        //use substring and use indexof 
        // ic number : 900831-07-8899
        // DOB: 900831 , State: 07 ,  Last4:8899
        //input the ic no. then generate the DOB , State , Last4

        string ic;
        Console.WriteLine("Please enter your IC number (900831-07-8899):");
        ic = Console.ReadLine();

        string DOB, State, Last4;
        DOB = ic.Substring(0, 6);
        int dash1 = ic.IndexOf('-') + 1;
        State = ic.Substring(dash1, 2);

        int lastdash = ic.LastIndexOf('-') + 1;
        Last4 = ic.Substring(lastdash, 4);

        Console.WriteLine($"DOB: {DOB} , State: {State} , Last4: {Last4}");

        //900831-07-8899
        string[] icDetails = ic.Split('-');

        Console.WriteLine($"DOB: {icDetails[0]} , State: {icDetails[1]} , Last4: {icDetails[2]}");


        //change ic format original 900831-07-8899  -> 900831/07/8899
        string ic_slash = string.Join("/", icDetails);
        Console.WriteLine("IC with slash: {0}", ic_slash);


    }
}

