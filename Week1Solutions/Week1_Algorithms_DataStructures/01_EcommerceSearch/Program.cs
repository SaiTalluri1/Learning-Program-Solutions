using System;

namespace EcommerceSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }
    }

    class Program
    {
        // Linear search by ID
        static Product? LinearSearch(Product[] products, int targetId)
        {
            foreach (var item in products)
            {
                if (item.ProductId == targetId)
                    return item;
            }
            return null;
        }

        // Binary search by ID (array must be sorted)
        static Product? BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == targetId)
                    return products[mid];
                else if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        static void Main()
        {
            Product[] items = new Product[]
            {
                new Product(101, "Phone", "Electronics"),
                new Product(103, "Laptop", "Electronics"),
                new Product(102, "Shoes", "Fashion"),
                new Product(104, "Book", "Stationery")
            };

            Console.WriteLine("Linear Search for ID 102:");
            var result1 = LinearSearch(items, 102);
            Console.WriteLine(result1 != null ? result1.ProductName : "Not found");

            // Sort by ProductId for binary search
            Array.Sort(items, (a, b) => a.ProductId.CompareTo(b.ProductId));

            Console.WriteLine("Binary Search for ID 103:");
            var result2 = BinarySearch(items, 103);
            Console.WriteLine(result2 != null ? result2.ProductName : "Not found");
        }
    }
}
