using System.Collections.Generic;
using PPModels;
namespace PPDL
{
    public interface IRepository
    {
        List<Store> GetAllStore();
        Store AddStore(Store store);
        Store GetStore(Store store);

        Store DeleteStore(Store store);
        Review AddStore(Store store, Review review);
        List<Review> GetReviews(Store store);
    }
}