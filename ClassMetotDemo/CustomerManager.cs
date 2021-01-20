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

        public void List(Customer customer)
        {
            Console.WriteLine("Customer list ");

         
        }
    }
}
