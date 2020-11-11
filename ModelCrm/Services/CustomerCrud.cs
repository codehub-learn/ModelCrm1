using ModelCrm.CrmDbContext;
using ModelCrm.Models;
using ModelCrm.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelCrm.Services
{
    public class CustomerCrud : ICustomerCrude
    {
        private CrmAppDbContext dbContext = new CrmAppDbContext();

        public Customer CreateCustomer(CustomerOptions customerOptions)
        {
            Customer customer = new Customer  { 
                FirstName = customerOptions.FirstName,
                LastName = customerOptions.LastName,
                Phone = customerOptions.Phone,
                Email= customerOptions.Email,
                VatNumber= customerOptions.VatNumber,
                Address =customerOptions.Address,
                Dob = customerOptions.Dob,
                CreatedDate = DateTime.Now,
                IsActive = true,
                TotalGross =0m
            };
            
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return customer;
        }

   

        public List<Customer> GetAllCustomers()
        {
     
            List<Customer> customers = dbContext.Customers.ToList() ;
            return customers;
        }

        public Customer UpdateCustomer(CustomerOptions customerOpt, int id)
        {
   
            Customer customer = dbContext.Customers.Find(id);
            customer.Address = customerOpt.Address;
            customer.Email =customerOpt.Email;
            dbContext.SaveChanges();

            return customer;
        }

        public bool DeleteCustomer(int id)
        {
             Customer customer = dbContext.Customers.Find(id);
            if (customer == null) return false;
            dbContext.Customers.Remove(customer);
            return true;

        }

        public Customer GetCustomerById(int id)
        {
             Customer customer = dbContext.Customers.Find(id);
            return customer;
        }
    }
}
