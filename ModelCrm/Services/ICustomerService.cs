using ModelCrm.Models;
using ModelCrm.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Services
{
   public interface ICustomerService
    {
        Customer CreateCustomer(CustomerOptions customerOptions);
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomers();
        Customer UpdateCustomer(CustomerOptions customerOpt, int id);
        bool DeleteCustomer(int id);

    }


}
