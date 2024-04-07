using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating products
        Product product1 = new Product("StellarGlow Facial Serum", "SGFS1234", 29.99, 50);
        Product product2 = new Product("AquaBlast Water Bottle", "ABWB2345", 12.99, 200);
        Product product3 = new Product("PowerMax Pro Protein Powder", "PMPPP3456", 39.99, 75);
        Product product4 = new Product("SwiftStride Running Shoes", "SSRS5678", 79.99, 25);
        Product product5 = new Product("ChillWave Bluetooth Speaker", "CWBS9876", 49.99, 100);


        // Creating addresses
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
        Address address2 = new Address("789 Pine Lane", "Riverside", "CA", "USA");
        Address address3 = new Address("456 Maple Avenue", "Oakville", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emma Johnson", address2);
        Customer customer3 = new Customer("Sarah Thompson", address3);

        // Create orders
        List<Product> products1 = new List<Product> { product1, product2 };
        Order order1 = new Order(products1, customer1);

        List<Product> products2 = new List<Product> { product3, product4 };
        Order order2 = new Order(products2, customer2);

        List<Product> products3 = new List<Product> { product5, product3 };
        Order order3 = new Order(products3, customer3);

        // Display the results for each order
        Console.WriteLine("Order 1");
        Console.WriteLine("-------");
        Console.WriteLine($"Total price: ${order1.TotalPrice()}");
        Console.WriteLine($"Packing label:\n{order1.PackingLabel()}");
        Console.WriteLine($"Shipping label:\n{order1.ShippingLabel()}");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("-------");
        Console.WriteLine($"Total price: ${order2.TotalPrice()}");
        Console.WriteLine($"Packing label:\n{order2.PackingLabel()}");
        Console.WriteLine($"Shipping label:\n{order2.ShippingLabel()}");
        Console.WriteLine();

        Console.WriteLine("Order 3");
        Console.WriteLine("-------");
        Console.WriteLine($"Total price: ${order3.TotalPrice()}");
        Console.WriteLine($"Packing label:\n{order3.PackingLabel()}");
        Console.WriteLine($"Shipping label:\n{order3.ShippingLabel()}");
    }
}