using System;


namespace PPBL
{
    public class StoreBL
    {
        
    }

    public Store DeleteStore(Store store)
    {
        StoreBL toBeDeleted = _repo.GetStore(store);
        if (toBeDeleted != null) return _repo.DeleteRestaurant(toBeDeleted);
        else throw new Exception("Store does not exit. Must've been deleted already :>");
    }

    public list<StoreBL> GetAllStores()
    {
        
    }
}