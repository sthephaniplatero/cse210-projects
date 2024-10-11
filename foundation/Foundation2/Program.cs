using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Elm St","Springfield", "CA", "USA");
        Customer customer1 = new Customer("Bonnie Burk",address1);

        Order order1 = new Order(customer1);

        Product product1= new Product("Snickers","S1236",180.93,1);
        Product product2= new Product("Skirt","SW153",39.96,2);
        Product product3= new Product("Boots","B5963",236.89,1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //Console.WriteLine(customer1.GetCustomerDetails());

        Console.WriteLine("\n" + order1.ShippingLabel());

        Console.WriteLine("\n" + order1.PackingLabel());

        Console.WriteLine($"Total of the order: $ {order1.GetTotal()}");


        Console.WriteLine("--------------------------------------------------------------------------");



        Address address2 = new Address("123 High Street", "London", "SW1A 1AA", "United Kingdom");
        Customer customer2 = new Customer("Patricia Smith",address2);

        Order order2 = new Order(customer2);

        Product product4= new Product("Pants","P2696",58.96,3);
        Product product5= new Product("Hoodee","H2652",63.96,2);
        Product product6= new Product("Sun Glasses","SG1896",145.10,1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        //Console.WriteLine(customer2.GetCustomerDetails());

        Console.WriteLine("\n" + order2.ShippingLabel());

        Console.WriteLine("\n" + order2.PackingLabel());

        Console.WriteLine($"Total of the order: $ {order2.GetTotal()}");



    }
}