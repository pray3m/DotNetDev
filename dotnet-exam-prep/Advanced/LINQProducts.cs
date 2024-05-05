// LINQ - Langugae Integrated Query

using System;
using System.Collections.Generic;

class LINQProducts
{
    public static void Main()
    {
        // Sample list of products
        List<Product> products = new List<Product>()
        {
            new Product(2, "Headphones", 50.00, "Electronics"),
            new Product(3, "Shirt", 20.00, "Clothing"),
            new Product(4, "Jeans", 30.00, "Clothing"),
            new Product(5, "Book", 15.00, "Books"),
            new Product(6, "iPhone", 499.00,"Electronics"),
        };

        // Query Expression syntax

        // Find all products with price above $20 (using product ID)
        IEnumerable<Product> expensiveProducts = from product in products
                                                 where product.Price > 20
                                                 orderby product.Price descending
                                                 select product;


        Console.WriteLine("Expensive Products (Query Expression):");
        foreach (Product product in expensiveProducts)
        {
            Console.WriteLine($"\t- ID: {product.ProductID}, Name: {product.Name} ({product.Category}) - ${product.Price}");
        }

        // --- Method-Based Syntax ---

        // Find all electronic products ordered by price (descending)
        var electronicProducts = products.Where(product => product.Category == "Electronics").OrderByDescending(product => product.Price);

        Console.WriteLine("\nElectronic Products (Method-Based - Descending Price):");
        foreach (var product in electronicProducts)
        {
            Console.WriteLine($"\t- ID: {product.ProductID}, Name: {product.Name} - ${product.Price}");
        }

    }
}

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public Product(int productID, string name, double price, string category)
    {
        ProductID = productID;
        Name = name;
        Price = price;
        Category = category;
    }
}