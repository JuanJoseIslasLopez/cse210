using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Schiller 4563", "Anytown", "MV", "Uruguay");
        Customer customer1 = new Customer("John Jhonson", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "1234", 1200, 1);
        Product product2 = new Product("Mouse", "5678", 20, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order Total: " + order1.GetOrderTotal());
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
    }
}