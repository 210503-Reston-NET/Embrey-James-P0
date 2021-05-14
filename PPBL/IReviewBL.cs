using PPModels;
using System;
using System.Collections.Generic;
namespace PPBL
{
    public interface IReviewBL
    {
        Review AddReview(Restaurant restaurant, Review review);
        Tuple<List<Review>, int> GetReviews(Restaurant restaurant);
    }
}