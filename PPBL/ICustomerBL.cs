using PPModels;
using System.Collections.Generic;


namespace PPBL
{
    public interface ICustomerBL
    {
//         // List<Customer> GetAllCustomers();
        Customers AddCustomer(Customers customers);
        Customers GetCustomer(Customers customers);
// //         Customer DeleteCustomer(Customer customer);
        // Customer AddCustomer(CustomerBL customer);

    }
}