using System;
using System.Collections.Generic;
using System.Linq;

class AndreyAndBilliard
{
    static void Main(string[] args)
    {
        int productsCount = int.Parse(Console.ReadLine());

        var shop = new Dictionary<string, double>();
        List<Customer> customers = new List<Customer>();

        for (int counter = 0; counter < productsCount; counter++)
        {
            string[] productArgs = Console.ReadLine()
                .Split('-')
                .ToArray();
			string productName = productArgs[0];
			double productPrice = double.Parse(productArgs[1]);

            shop[productName] = productPrice;
        }

		string input;

        while ((input = Console.ReadLine()) != "end of clients")
        {
            string[] orderArgs = input
                .Split("-,".ToCharArray())
                .ToArray();
            string customerName = orderArgs[0];
            string productName = orderArgs[1];
            int quantity = int.Parse(orderArgs[2]);

            Customer customer = new Customer(customerName);

            if (shop.ContainsKey(productName))
            {
                if (customers.Any(x => x.Name == customerName))
                {
                    int index = 0;
                    foreach (var cust in customers)
                    {
                        if (cust.Name == customerName)
                        {
                            index = customers.IndexOf(cust);
                        }
                    }

                    customer = customers[index];
                }
                else
                {
                    customers.Add(customer);
                }

                if (customer.Orders.ContainsKey(productName) == false)
                {
                    customer.AddOrder(productName);
                }

                customer.Orders[productName] += quantity;
            }
        }

        double totalBill = 0;

        foreach (var customer in customers.OrderBy(x => x.Name))
        {
            Console.WriteLine(customer.Name);
            double bill = 0;
            foreach (var order in customer.Orders)
            {
                Console.WriteLine($"-- {order.Key} - {order.Value}");
                bill += order.Value * shop[order.Key];
            }

            Console.WriteLine($"Bill: {bill:F2}");
            totalBill += bill;
        }

        Console.WriteLine($"Total bill: {totalBill:F2}");
    }
}

class Customer
{
	public Customer(string name)
	{
		this.Name = name;
		this.Orders = new Dictionary<string, int>();
	}

    public string Name { get;  }
    public Dictionary<string, int> Orders { get; }

	public void AddOrder(string productName)
	{
		this.Orders.Add(productName, 0);
	}
}