namespace PPBL
{
    public class ReviewBL:IReviewBL
    {
        private IRepository _repo;

        public ReviewBL(IRepository repo)
        {
            _repo = repo;
        }
        public Review AddReview(Store store, Review review)
        {
            //cal repo method to add review
            _repo.AddReview(restaurant, review);
            return review;
        }

        public Tuple<List<ReviewBL>, int> GetReviews(Store store)
        {
            //cal get review from my RepoDB
            List<Review> storeReviews = _repo.GetReviews(restaurant);
            int averageRating = 0;
            storeReviews.ForEach(ReviewBL => averageRating += ReviewBL.Rating);
            averageRating = averageRating / storeReviews.Count;
            return new Tuple<List<ReviewBL>, int> (storeReviews, averageRating);
        }
    }
}