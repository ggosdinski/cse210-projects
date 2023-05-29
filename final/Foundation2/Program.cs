class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // create products
        Product product1 = new Product("Iphone 13", "1767", 999, 2);
        Product product2 = new Product("Ipad 10", "2532", 599, 5);
        Product product3 = new Product("Macbook Air M2", "4370", 1200.99, 1);

        // order 1
        Order order1 = new Order();
        Address address1 = new Address("Los Fortines 326", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Spencer Wright", address1);
        order1.AddItem(product1);
        order1.AddItem(product3);
        // order1.PrintAllCosts(address1);
        order1.PrintPackingLabel();
        order1.PrintTotalCost(address1);
        order1.PrintShippingLabel(address1, customer1);
        Console.WriteLine();

        // order 2
        Order order2 = new Order();
        Address address2 = new Address("Florida 455", "Amsterdam", "North Holland", "Netherlands");
        Customer customer2 = new Customer("Christian Melander", address2);
        order2.AddItem(product2);
        order2.AddItem(product3);
        // order2.PrintAllCosts(address2);
        order2.PrintPackingLabel();
        order2.PrintTotalCost(address2);
        order2.PrintShippingLabel(address2, customer2);
    }
}