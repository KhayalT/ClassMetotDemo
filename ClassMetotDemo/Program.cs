using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer {
            Id=1,Name="Khayal",Surname="Teyyubov",VoenNumber="1234432212"
            };

          CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.List(customer);
            customerManager.Delete(customer);

        }
    }
}
