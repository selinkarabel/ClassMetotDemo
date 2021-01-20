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

            Customer customers3 = new Customer();
            customers3.Id = 3;
            customers3.CustomerName = "Chivas";
            customers3.CustomerSurname = "K";
            customers3.TCKN = "12345678914";


            Customer[] customers = new Customer[] {customers1, customers2 };

          


            Console.WriteLine("-------------------Metotlar-------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customers3);
            customerManager.Delete(customers3);
            customerManager.List(customers);

        }
    }
}
