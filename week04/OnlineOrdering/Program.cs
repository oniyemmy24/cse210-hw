using System;

class Program
{
    static void Main(string[] args)
      {
        Address address1 = new Address("20 Main Srt", "Idaho", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));
        
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smart Tv.", "T789", 499.99, 1));
        order2.AddProduct(new Product("Solar-panel", "C012", 19.99, 3));
        
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
        Console.WriteLine();

        Address address3 = new Address("32 Creek Road", "Apapa", "Lagos", "Nigeria");
        Customer customer3 = new Customer("Oluwayemi Oni", address3);
         
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Shoe last", "L700", 100.99, 2));
        order3.AddProduct(new Product("Sowing Machine", "S015", 200.99, 2));
        
        Console.WriteLine("Order 3:");
        Console.WriteLine("Packing Label:\n" + order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order3.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order3.GetTotalPrice());
    }
}
