using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Mabini St", "Navotas City", "Metro Manila", "Philippines");
        Customer customer1 = new Customer("Juan Dela Cryz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mouse", "P001", 900, 1));
        order1.AddProduct(new Product("Mouse Trap", "P002", 10, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
    }
}