using System; 
using System.Collections.Generic; 
using PPDL;
using PPModels;

namespace PPBL
{
    public class CustomerBL : ICustomerBL
    {
        

    private IRepository _repo;

    public CustomerBL(IRepository repo)
    {
        _repo = repo;
    }

    public Customers AddCustomer(Customers customers)
    {
        if(_repo.GetCustomer(customers)!=null)
        {
            throw new Exception ("Customer already exists!");
        }
        return _repo.AddCustomer(customers);
    }

    public Customers GetCustomer(Customers customers)
    {
        return _repo.GetCustomer(customers);
    }
}
}