using System.Collections.Generic;
using PPModels;

namespace PPDL
{
    /// <summary>
    /// Store Reviews static collection storage
    /// </summary>
    public class PPSCStorage
    {
        public static List<Store> Stores = new List<Store>()
        {
            new Store("Patrick's Peppers", "Harrisburg", "Pennsylvania")
        };
    }
}