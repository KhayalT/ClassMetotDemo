﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " Added to database");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " Listed");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " Deleted");
        }
    }
}
