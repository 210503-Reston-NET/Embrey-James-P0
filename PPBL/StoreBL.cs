using System.Collections.Generic;
using PPModels;
using PPDL;
using System;

namespace PPBL
{
    /// <summary>
    /// Business logic class for the store model
    /// </summary>
    public class StoreBL : IStoreBL
    {
        // Some things to note:
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app. 
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL 
        private IRepository _repo;
        public StoreBL(IRepository repo)
        {
            _repo = repo;
        }

        public Store AddStore(Store store)
        {
            // Todo: call a repo method that adds a restaurant
            if (_repo.GetStore(store) != null)
            {
                throw new Exception("Store already exists :<");
            }
            return _repo.AddStore(restaurant);
        }

        public Store DeleteStore(Store store)
        {
            Restaurant toBeDeleted = _repo.GetStore(store);
            if (toBeDeleted != null) return _repo.DeleteStore(toBeDeleted);
            else throw new Exception("Restaurant does not exist. Must've been deleted already :>");
        }

        public List<Store> GetAllStores()
        {
            //Note that this method isn't really dependent on any inputs/parameters, I can just directly call the 
            // DL method in charge of getting all restaurants
            return _repo.GetAllStores();
        }

        public Store GetStore(Store store)
        {
            return _repo.GetStore(store);
        }
    }
}