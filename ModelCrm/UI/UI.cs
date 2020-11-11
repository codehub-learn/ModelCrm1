using ModelCrm.Models;
using ModelCrm.Options;
using ModelCrm.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.UI
{
    public class Ui 
    {
        private CustomerCrud custCrud = new CustomerCrud();

        public void io()
        {
            CustomerOptions custOpt = new CustomerOptions
            {
                FirstName = "Dimitris",
                LastName = "Dimitriou",
                Address = "Athens",
                VatNumber = "012345678",
                Email = "dimitriou@mail.com",
                Phone = "210-74 000 111",
                Dob = new DateTime(1970, 12, 31),
            };

           

            Customer customer = custCrud.CreateCustomer(custOpt);

            //Console.WriteLine("Id = " 
            //    + customer.Id  
            //    + " FirstName= "
            //    + customer.FirstName);


            Console.WriteLine($"Id = {customer.Id} " +
                $"FirstName= {customer.FirstName}");

            Customer toFind = custCrud.GetCustomerById(1);
            Console.WriteLine($"Id = {toFind.Id} " +
                $"FirstName= {toFind.FirstName}");

            toFind = custCrud.GetCustomerById(100);
            if (toFind != null)
            {
                Console.WriteLine($"Id = {toFind.Id} " +
                    $"FirstName= {toFind.FirstName}");
            }

        }



    }
}
