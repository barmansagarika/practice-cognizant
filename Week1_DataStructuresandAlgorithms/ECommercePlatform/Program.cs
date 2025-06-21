using System;

namespace ECommercePlatform
{
    class Program
    {
        static void Main()
        {
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Phone", "Electronics"),
                new Product(3, "Shirt", "Clothing"),
                new Product(4, "Shoes", "Footwear"),
                new Product(5, "Headphones", "Electronics")
            };

            Array.Sort(products, (p1, p2) => string.Compare(p1.ProductName, p2.ProductName));

            Console.WriteLine("Enter product name to search:");
            string searchTerm = Console.ReadLine();

            var linearResult = SearchAlgorithms.LinearSearch(products, searchTerm);
            Console.WriteLine("\nLinear Search Result:");
            Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found.");

            var binaryResult = SearchAlgorithms.BinarySearch(products, searchTerm);
            Console.WriteLine("\nBinary Search Result:");
            Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found.");
        }
    }
}
