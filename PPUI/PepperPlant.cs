using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PPBL;
using PPDL;
using PPDL.Entities;

namespace PPUI
{
    /// <summary>
    /// Class to menufacture menus using factory dp
    /// </summary>
    public class PepperPlant
    {
        public static IMenu GetMenu(string menuType)
        {
            //getting configurations from a config file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //setting up my db connections
            string connectionString = configuration.GetConnectionString("RestaurantDB");
            //we're building the dbcontext using the constructor that takes in options, we're setting the connection
            //string outside the context def'n
            DbContextOptions<RestaurantDBContext> options = new DbContextOptionsBuilder<RestaurantDBContext>()
            .UseSqlServer(connectionString)
            .Options;
            //passing the options we just built
            var context = new RestaurantDBContext(options);

            switch (menuType.ToLower())
            {
                case "main":
                    return new MainMenu();
                case "store":
                    return new StoreMenu(new StoreBL(new RepoDB(context)), new ValidationService());
                case "review":
                    return new ReviewMenu(new StoreBL(new RepoDB(context)), new ValidationService(), new ReviewBL(new RepoDB(context)));
                default:
                    return null;
            }
        }

    }
}