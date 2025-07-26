using System;

class Program
{
    static void Main(string[] args)
    {
        Address adress1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Juan", adress1);
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Beef", 111222, 3.77F, 3));
        products1.Add(new Product("Soap", 100001, 2.0F, 2));
        products1.Add(new Product("Bread", 223344, 1.50F, 1));

        Order order1 = new Order(products1, customer1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotalCost());

        Address adress2 = new Address("222 One Ave", "Tijuana", "IDK", "Mexico");
        Customer customer2 = new Customer("Janet", adress2);
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Ham", 111223, 4.75F, 4));
        products2.Add(new Product("Soap", 100001, 2.0F, 2));
        products2.Add(new Product("Butter", 223333, 3.10F, 10));

        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetTotalCost());
    }
}