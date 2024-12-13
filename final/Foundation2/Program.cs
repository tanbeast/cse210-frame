using System;
using System.Collections.Generic;

// Main Program class to run the system
class Program{
    static void Main()
    {
        // Create some addresses
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("JDavid Man", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create some products
        Product product1 = new Product("Laptop", 101, 500, 1);
        Product product2 = new Product("Mouse", 102, 25, 2);
        Product product3 = new Product("Keyboard", 103, 75, 1);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display details for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Display details for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}
