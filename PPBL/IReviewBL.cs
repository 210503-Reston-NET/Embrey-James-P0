using RRModels;
using System;
using System.Collections.Generic;

namespace PPBL
{
    public interface IReviewBL
    {
        Review AddReview(Store store, Review review);
        Tuple<List<Review>, int> GetReviews(Store store);
    }
}