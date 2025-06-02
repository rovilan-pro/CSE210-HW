using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Mabini St", "Navotas City", "Metro Manila", "Philippines");
        Customer customer1 = new Customer("Juan Dela Cruz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mouse", "P001", 900, 1));
        order1.AddProduct(new Product("Mouse Trap", "P002", 10, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: P{order1.GetTotalCost():0.00}");

        Console.WriteLine();

        Address address2 = new Address("123 Del Pilar St", "Cabanatuan City", "Nueva Ecija", "Philippines");
        Customer customer2 = new Customer("Rizal Juanez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Key Chain", "P0010", 25, 100));
        order2.AddProduct(new Product("Keyboard", "P0011", 999.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: P{order2.GetTotalCost():0.00}");
    }
}