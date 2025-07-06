using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
using RetailInventory.Data;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("===== EF Core Hands-On =====");

        await RunLab3_CreateDatabaseAsync();
        await RunLab4_InsertDataAsync();
        await RunLab5_RetrieveDataAsync();

        Console.WriteLine("===== All Labs Completed =====");
    }

    static async Task RunLab3_CreateDatabaseAsync()
    {
        Console.WriteLine("\n--- Lab 3: Creating Database ---");

        using var context = new AppDbContext();
        await context.Database.EnsureCreatedAsync(); 

        Console.WriteLine("Lab 3 completed: Database ensured.");
    }

    static async Task RunLab4_InsertDataAsync()
    {
        Console.WriteLine("\n--- Lab 4: Inserting Data ---");

        using var context = new AppDbContext();

        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);
        await context.SaveChangesAsync();

        Console.WriteLine("Lab 4 completed: Sample data inserted.");
    }

    static async Task RunLab5_RetrieveDataAsync()
    {
        Console.WriteLine("\n--- Lab 5: Retrieving Data ---");

        using var context = new AppDbContext();

        var products = await context.Products.ToListAsync();
        Console.WriteLine("\nAll Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        var productById = await context.Products.FindAsync(1);
        Console.WriteLine($"\nProduct with ID 1: {productById?.Name}");

        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"Expensive Product: {expensive?.Name}");

        Console.WriteLine("Lab 5 completed: Data retrieved.");
    }
}
