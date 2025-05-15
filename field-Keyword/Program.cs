// See https://aka.ms/new-console-template for more information

namespace Program;
using System;
using field_Keyword;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Practicing field keyword");

        Console.WriteLine("Before c# 13");

        WithOutFieldKeyWord product = new WithOutFieldKeyWord();
        product.Price = 100;
        Console.WriteLine($"Product price: {product.Price}");
     


        Console.WriteLine("After c# 13");
        WithFieldKeyWord product1 = new WithFieldKeyWord();
        product1.Name = "Laptop";
        Console.WriteLine($"Product name: {product1.Name}");

    }
}