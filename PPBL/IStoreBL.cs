using PPModels;
using System.Collections.Generic;

namespace PPBL
{
    public interface IReviewBL
    {
        List<Store> GetAllStores();
        Store AddStore(Store store);
        Store GetStore(Store store);
        Store DeleteStore(Store store);

    }
}