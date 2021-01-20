using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer customers1 = new Customer();
            customers1.Id = 1;
            customers1.CustomerName = "Selin";
            customers1.CustomerSurname = "K";
            customers1.TCKN = "12345678912";

            Customer customers2 = new Customer();
            customers2.Id = 2;
            customers2.CustomerName = "Cengizhan";
            customers2.CustomerSurname = "K";
            customers2.TCKN = "12345678913";


            Customer[] customers = new Customer[] {customers1, customers2 };

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.CustomerName);
                Console.WriteLine(c.CustomerSurname);
                Console.WriteLine(c.TCKN);
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("-------------------Metotlar-------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customers1);
            customerManager.Delete(customers1);
            customerManager.List(customers1);

        }
    }
}
