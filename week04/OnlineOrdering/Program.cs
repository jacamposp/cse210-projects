using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "A101", 25.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "A202", 9.50, 3));
        order1.AddProduct(new Product("Laptop Stand", "A303", 39.99, 1));

        Address address2 = new Address("Calle 5, Avenida 2", "Heredia", "Heredia", "Costa Rica");
        Customer customer2 = new Customer("Maria Lopez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "B110", 79.99, 1));
        order2.AddProduct(new Product("Mouse Pad", "B220", 12.00, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}