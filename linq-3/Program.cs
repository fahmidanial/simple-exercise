using System;

class Program
{
    static void Main(string[] args)
    {

        // create a new List of strings
        var items = new List<string>();  // items is empty 

        // display List’s Count and Capacity before adding elements
        Console.WriteLine("Before adding to items: " +
           $"Count = {items.Count}; Capacity = {items.Capacity}"); //Count -> 0 capacity-> 5

        items.Add("red"); // append an item to the List       Items -> red   
        items.Insert(0, "yellow"); // insert the value at index 0 
                                   // items-> yellow , red

        // display List’s Count and Capacity after adding two elements
        Console.WriteLine("After adding two elements to items: " +
           $"Count = {items.Count}; Capacity = {items.Capacity}"); //count -> 2 , capcity

        // display the colors in the list
        Console.Write(
           "\nDisplay list contents with counter-controlled loop:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.Write($" {items[i]}");
        }
        // items-> yellow , red

        // display colors using foreach 
        Console.Write("\nDisplay list contents with foreach statement:");

        // items-> yellow , red

        items.Add("green"); // add "green" to the end of the List
                            // items-> yellow , red , green

        items.Add("yellow"); // add "yellow" to the end of the List
                             // items-> yellow , red , green, yellow

        // display List’s Count and Capacity after adding two more elements
        Console.WriteLine("\n\nAfter adding two more elements to items: " +
           $"Count = {items.Count}; Capacity = {items.Capacity}"); //count: 4

        // display the List
        Console.Write("List with two new elements:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        // items-> yellow , red , green, yellow

        items.Remove("yellow"); // remove the first "yellow"
                                // items-> red , green, yellow
                                // display the List
        Console.Write("\n\nRemove first instance of yellow:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        // items-> red , green, yellow

        items.RemoveAt(1); // remove item at index 1
                           // items-> red , yellow

        // display the List
        Console.Write("\nRemove second list element (green):");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }
        // items-> red , yellow

        // display List’s Count and Capacity after removing two elements
        Console.WriteLine("\nAfter removing two elements from items: " +
           $"Count = {items.Count}; Capacity = {items.Capacity}"); //count: 2

        // check if a value is in the List
        // items-> red , yellow
        Console.WriteLine("\n\"red\" is " +
           $"{(items.Contains("red") ? string.Empty : "not ")}in the list");
        //items.Contains ("red") if the red is in items it will return true otherwise false

        // items-> red , yellow
        items.Add("orange"); // add "orange" to the end of the List
                             // items-> red , yellow, orange

        items.Add("violet"); // add "violet" to the end of the List
                             // items-> red , yellow, orange, violet

        items.Add("blue"); // add "blue" to the end of the List
                           // items-> red , yellow, orange, violet, blue

        // display List’s Count and Capacity after adding three elements
        Console.WriteLine("\nAfter adding three more elements to items: " +
           $"Count = {items.Count}; Capacity = {items.Capacity}"); //count

        // display the List
        Console.Write("List with three new elements:");
        foreach (var item in items)
        {
            Console.Write($" {item}");
        }

        // items-> red , yellow, orange, violet, blue

        Console.WriteLine();


    }
}





