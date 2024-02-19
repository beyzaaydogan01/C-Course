﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();   
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id= 1;
            customer.FirstName = "Beyza"; 
            customer.LastName = "Aydoğanoğlu";


            Customer customer2 = new Customer()
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Engin",
                LastName = "Demiroğ"

            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
}
