﻿using System;


class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\temp\TopFive.csv";

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("Rank") != -1) line = line.ToUpper();
                    if (line.IndexOf("Sia") != -1) line += " ft.Sean Paul";

                    string[] sub = line.Split(',');
                    line = String.Format("{0,-30} {1,-20}", sub[1], sub[2]);
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception error)
        { Console.WriteLine(error.Message); }
        Console.ReadKey();

    }
}

//inside c put temp and create TopFive.csv file