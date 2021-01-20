using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is added.. " + customer.CustomerName, customer.CustomerSurname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted.. " + customer.CustomerName, customer.CustomerSurname);
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("Customer list ");
            foreach (Customer c in customers)
            
            {
                Console.WriteLine(c.CustomerName);
                Console.WriteLine(c.CustomerSurname);
                Console.WriteLine(c.TCKN);
                Console.WriteLine("------------------------------");
            }

        }
    }
}
