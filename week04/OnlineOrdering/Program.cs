using System;

class Program
{
    //Leonardo Wilches - W04 Assignment: Online Ordering Program (Foundation #2)

    static void Main(string[] args)
    {
        Address address1 = new Address("123 Mapple Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Stephen Jones", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1200.50m, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.99m, 2));

        Address address2 = new Address("321 Avenida Providencia", "Santiago", "RM", "Chile");
        Customer customer2 = new Customer("Amanda Martinez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Camera", "P2001", 500.00m, 1));
        order2.AddProduct(new Product("Tripod", "P2002", 45.00m, 1));
        order2.AddProduct(new Product("Wide Angle Lens", "P2003", 15.50m, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}