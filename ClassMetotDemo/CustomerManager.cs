using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Customer Added");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }
        public void Uptade(Customer customer)
        {
            Console.WriteLine("Customer Uptaded");
        }

    }
}
