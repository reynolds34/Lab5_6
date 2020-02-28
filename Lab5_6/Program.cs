using System;

namespace Lab5_6
{
    class Program
    {

        struct Customer
        {
            public int customer_age;
            public string first_name;
            public string last_name;
            public bool premium_member;


            static void Main(string[] args)
            {
                Console.WriteLine("Teen drinking is very bad, I have a premium membership though");

                Customer customer1 = new Customer
                {
                    customer_age = 18,
                    first_name = "Mitch",
                    last_name = "Krezbiot",
                    premium_member = false,
                };


                Customer customer2 = new Customer
                {
                    customer_age = 25,
                    first_name = "Andre",
                    last_name = "Torres",
                    premium_member = true,
                };

                Customer customer3 = new Customer
                {
                    customer_age = 22,
                    first_name = "Emma",
                    last_name = "Wendt",
                    premium_member = false,
                };

                Customer[] allCustomers = { customer1, customer2, customer3 };

                for (int i = 0; i < allCustomers.Length; i++)
                {
                    if(allCustomers[i].customer_age < 21)
                    {
                        Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is not allowed to purchase alcohol.");
                    }
                    else
                    {
                        Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is allowed to purchase alcohol.");
                    }

                    if (allCustomers[i].premium_member == false)
                    {
                        Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a basic member.");
                    }
                    else
                    {
                        Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");
                    }

                }

            }
        }
    }
}
