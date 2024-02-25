using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create instances of Customer and Address
        Address address1 = new Address { Street = "123 Main St", City = "New York", State = "NY", Country = "USA" };
        Customer customer1 = new Customer { Name = "John Doe", Address = address1 };

        // Create an order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product { Name = "Product 1", ProductId = "P001", Price = 10, Quantity = 2 });
        order1.AddProduct(new Product { Name = "Product 2", ProductId = "P002", Price = 15, Quantity = 1 });

        // Display order details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        // Create another order
        Address address2 = new Address { Street = "456 Elm St", City = "Los Angeles", State = "CA", Country = "USA" };
        Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product { Name = "Product 3", ProductId = "P003", Price = 20, Quantity = 3 });

        // Display order details
        Console.WriteLine("\nOrder 2 Details:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}

