using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order Number 1");
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("Licorice", 17947673, 3.44, 2);
        products1.Add(product1);
        Product product2 = new Product("Macaroni", 58970348, 1.25, 3);
        products1.Add(product2);
        Product product3 = new Product("Brownie Mix", 06893625, 1.49, 1);
        products1.Add(product3);
        Address address1 = new Address("1930 Steeple Way", "", "Tacoma", "98034", "WA", "USA");
        Customer customer1 = new Customer("Philliam Nye", address1);
        
        Order order1 = new Order(customer1, address1, products1);
            
        order1.PackingLabel();
        order1.shippingLabel();

        Console.WriteLine("\n————————————————————————————————————————————————————————————————————————————————————————————————————————");
        Console.WriteLine("");
        Console.WriteLine("Order Number 2");
        List<Product> products2 = new List<Product>();
        Product product4 = new Product("Ice Cream", 58375938, 5.89, 1);
        products2.Add(product4);
        Product product5 = new Product("Pizza", 67823450, 1.25, 2);
        products2.Add(product4);
        Product product6 = new Product("Socks", 05683632, 1.99, 8);
        products2.Add(product6);
        Address address2 = new Address("5893 Main St", "Apt 2", "Saskatoon", "59202", "SK", "Canada");
        Customer customer2 = new Customer("Brutus Kiln", address1);
        
        Order order2 = new Order(customer2, address2, products2);
            
        order2.PackingLabel();
        order2.shippingLabel();
    }
}