using System.Collections.Generic;
using PPModels;
using Entity = PPDL.Entities;


namespace PPDL
{
    public interface IRepository
    {
        // List<Customer> GetAllCustomers();
        Customers AddCustomer(Customers customers);
        Customers GetCustomer(Customers customers);


    }
}