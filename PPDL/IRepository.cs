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
        // Products GetProducts(Products products);
        Orders AddOrder(Orders orders);
        Orders GetOrders(Orders orders);

        void UpdateOrder(Orders order2BeUpdated);

    }
}