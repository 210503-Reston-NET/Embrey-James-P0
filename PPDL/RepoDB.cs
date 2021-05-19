using System.Collections.Generic;
using Model = PPModels;
using Entity = PPDL.Entities;
using System.Linq;



namespace PPDL
{
    public class RepoDB : IRepository
    {
        private Entity.PPDBContext _context;
        
        public RepoDB(Entity.PPDBContext context) 
        {
            _context = context;
        }
        
        public Model.Customers AddCustomer(Model.Customers customers)
        {
            
            _context.Customers.Add(
                new Entity.Customer{
                CustomerName = customers.Name,
                CustomerLocale = customers.Locale,
                }
            );
            _context.SaveChanges();
            return customers;
        }

        // public List<Model.Customers> GetAllCustomers()
        // {
        //     return _context.Customers
        //     .Select(
        //         customers => new Model.Customers(customers.Name, customer.Locale, customer.Quantity)
        //     ).ToList();
        // }


        public Model.Customers GetCustomer(Model.Customers customers)
        {
            Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.CustomerName == customers.Name && custo.CustomerLocale == customers.Locale);
            if(found == null) return null;
            return new Model.Customers(found.CustomerName, found.CustomerLocale);
        }

        // public void UpdateProduct(Product product2BUpdated)
        // {
        //     Entity.Product oldProduct = _context.Products.Find(product2BUpdated.Id);
        //     _context.Entry(oldProduct).CurrentValues.SetValues(product2BUpdated);

        //     //Because I am not mapping the hero property in my mapper, i am unable to use the method
        //     //_context.Entry(oldSuperPower).CurrentValues.SetValues(_mapper.ParseSuperPower(hero2BUpdated.SuperPower))
        //     // this would throw an error because i have established a 1:1 relationship between my heroes and superpower
        //     //tables. Instead, I take advantage of the change tracker and use it to update the superpower
        //     Entity.Product oldProducts = _context.Productz.Find(product2BUpdated.Product.Id);
        //     oldProduct.productQuantity = product2BUpdated.productQuantity;

        //     _context.SaveChanges();

        //     //This method clears the change tracker to drop all tracked entities
        //     _context.ChangeTracker.Clear();
        // }
    // }
    // {
    //     private Entity.PPDBContext _context;


    //     public RepoDB(Entity.PPDBContext context)
    //     {
    //         _context = context;
    //     }
    //     public PPModels.Customers AddCustomer(PPModels.Customers customers)
    //         {
    //         //This records a change in the context change tracker that we want to add this particular entity to the 
    //         // db
    //                 Entity.Customer tobeAdded = _context.Customers.First(custo => custo.Id == customers.Id);
    //                 _context.Customers.Add(toBeAdded);
    //                 _context.SaveChanges();
    //                 return customers;
    //                 _context.Customers.Add(
    //                 new Entity.Customer
    //                 {
    //                     CustomerName = customers.Name
    //                 }
    //                 );
    // // //         //This persists the change to the db
    // // //         // Note: you can create a separate method that persists the changes so that you can execute repo commands in
    // // //         //the BL and save changes only when all the operations return no exceptions
    //                 _context.SaveChanges(customers);
    //                 return customers;
    //         }

        
        
    // // //     public PPModels.Location AddLocation(Location location)
    // // //     {
    // // //         _context.Locations.Add(
    // // //             new Entity.Location
    // // //             {
    // // //                 LocationName = location.Name,
    // // //                 LocationCity = location.City,
    // // //                 LocationState = location.State,
    // // //             }
    // // //         );
    // // //         _context.SaveChanges();
    // // //         return location;
    // // //     }

    // // //     // public Customers DeleteCustomer(Customers customers)
    // // //     // {
    // // //     //     Entity.Customer toBeDeleted = _context.Customers.First(custo => custo.Id == customers.Id);
    // // //     //     _context.Customers.Remove(toBeDeleted);
    // // //     //     _context.SaveChanges();
    // // //     //     return customers;
    // // //     // }

    // // //     // public List<PPModels.Customers> GetAllCustomers()
    // // //     // {
    // // //     //     return _context.Customers
    // // //     //     .Select(
    // // //     //         customers => new PPModels.Customers(customers.CustomerName, customers.CustomerLocale)
    // // //     //     ).ToList();
    // // //     // }

    // // //     // public PPModels.Customers GetCustomer(PPModels.Customers customers)
    // // //     // {
    // // //     //     Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.Name == customers.Name);
    // // //     //     if (found == null) return null;
    // // //     //     return new Customer(found.CustomerId, found.CustomerName, found.CustomerLocale);
    // // //     // }

    // // //     public List<Customers> GetCustomers(Customers customers)
    // // //     {
    // // //         return _context.Customers.Where(
    // // //             customers => name.CustomerId == GetCustomer(customer).Id
    // // //             ).Select(
    // // //                 customers=> new PPModels.Customers
    // // //                 {
    // // //                     customerId = customer.Id,
    // // //                 }
    // // //             ).ToList();
    // // //     }

    //         public Orders GetOrders(Orders orders)
    //         {
    //             Entity.Order;
    //         }
        }
}