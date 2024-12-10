using System;
using System.Collections.Generic;

// Class to represent an Address
class Address{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country){
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInUSA(){
        return country.ToLower() == "usa";
    }

    public string GetFullAddress(){
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

// Class to represent a Product 
class Product{
    private string name;
    private int productId;
    private decimal pricePerUnit;
    private int quantity;


    public Product(string name, int productId, decimal pricePerUnit, int quantity){
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost(){
        return pricePerUnit * quantity;
    }

    public string GetPackingLabel(){
        return $"{name} (ID: {productId})";
    }
}

// Class to represent a Customer
class Customer{
    private string name;
    private Address address;


    public Customer(string name, Address address){
        this.name = name;
        this.address = address;
    }

    public string GetName(){
        return name;
    }

    public bool IsFromUSA(){
        return address.IsInUSA();
    }

    public string GetFullAddress(){
        return address.GetFullAddress();
    }
}

// Class to represent an Order with encapsulation
class Order{
    private Customer customer;
    private List<Product> products;
    private decimal shippingCost;

    public Order(Customer customer){
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product){
        products.Add(product);
    }

    public decimal GetTotalPrice(){
        decimal totalCost = 0;
        foreach (var product in products){
            totalCost += product.GetTotalCost();
        }

        shippingCost = customer.IsFromUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }


    public string GetPackingLabel(){
        string packingLabel = "Packing Label:\n";

        foreach (var product in products){
            packingLabel += product.GetPackingLabel() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel(){
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetFullAddress()}";
    }
}

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
