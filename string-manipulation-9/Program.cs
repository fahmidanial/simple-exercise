using System;


class Program
{
    static void Main(string[] args)
    {


        string car1 = "Ghibli"; //car1 - string 
        string car2 = "GranTurismo";  //car2 - string 
                                      //Car1 -> Ghibli
                                      //Car2 -> GranTurismo

        Console.Write("Original: ");
        Console.WriteLine("\tCar 1: " + car1 + "\t\tCar 2: " + car2);
        //Car1 -> Ghibli
        //Car2 -> GranTurismo

        car1 = String.Copy(car2); //copy value of car2 to car1 
        Console.Write("\nCopied: ");
        Console.WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);
        //Car1 -> GranTurismo
        //Car2 -> GranTurismo

        int num = car1.Length; //  11
        char[] model = new char[num]; //create a space an array of character sizeof 11

        car1.CopyTo(0, model, 0, num); //Take Car1 GranTurismo (position 0) G,  model at position 0
                                       //model (array) G r a n T u r i s m o (as array of character)

        Console.Write("\nCharacter Array: ");
        foreach (char c in model) { Console.Write(c + " "); }

        //Car1 -> GranTurismo
        //Car2 -> GranTurismo
        car1 = car1.Remove(4);// in Car1 T is a at position 4 from position remove all.  ->Gran
        Console.WriteLine("\n\nRemoved...\tCar 1: " + car1);
        //Car1 -> Gran
        //Car2 -> GranTurismo


        car1 = car1.Insert(0, "Maserati "); //Car1-> Gran position 0/ G insert Maserati -> Maserati Gran
                                            //car1 -> Maserati Gran  
        car1 = car1.Insert(13, "Cabrio"); //Car1 13 next to n of Gran to insert Cabrio
                                          // Car1 -> Maserati GranCabrio
        Console.WriteLine("\nInserted...\tCar 1: " + car1);

        car1 = car1.Replace("GranCabrio", "Quattroporte");  //replace the value of GranCabrio with a new value

        //car1 Maserati Quattroporte
        Console.WriteLine("\nReplaced...\tCar 1: " + car1);
        Console.ReadKey();


    }
}

