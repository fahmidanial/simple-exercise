using System;

class Program
{
    static void Main(string[] args)
    {
        PrintOrderDetails("Gift Shop", 31, "Red Mug");

        PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
        PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
        Console.ReadLine();

    }

    static void PrintOrderDetails(string sellerName, int orderNum, string productName)
    {
        Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: 	{productName}");
    }
}













           