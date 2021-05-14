using System;
using System.Collections.Generic;
using PPBL;
using PPModels;

namespace PPUI
{
    public class ReviewMenu : IMenu
    {
        private IStoreBL _storeBL;
        private IReviewBL _reviewBL;
        private IValidationService _validate;
        public ReviewMenu(IStoreBL storeBL, IValidationService validation, IStoreBL reviewBL)
        {
            _storeBL = storeBL;
            _validate = validation;
            _reviewBL = reviewBL;
        }
        public void Start()
        {
            bool repeat = true;
            // Add a review
            Store reviewable = SearchStore();
            if (reviewable != null)
            {
                do
                {
                    Console.WriteLine($"Welcome to the reviews menu of {reviewable.Name}! What would you like to do?");
                    Console.WriteLine("[0] Add a review");
                    Console.WriteLine("[1] View reviews");
                    Console.WriteLine("[2] Go back");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "0":
                            //Add review method
                            AddReview(reviewable);
                            break;
                        case "1":
                            //View review method
                            ViewReviews(reviewable);
                            break;
                        case "2":
                            //Return to home screen method
                            repeat = false;
                            Console.WriteLine("Going back to home screen");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                } while (repeat);

            }
            
        }

        private void ViewReviews(Store reviewable)
        {
            Console.WriteLine($"Here are the reviews for the store {reviewable.Name}");
            Tuple<List<Review>, int> reviewResult = _reviewBL.GetReviews(reviewable);
            reviewResult.Item1.ForEach(review => Console.WriteLine(review.ToString()));
            Console.WriteLine($"Overall rating of the store: {reviewResult.Item2}");
        }

        private void AddReview(Store reviewable)
        {
            int rating = _validate.ValidateInt("Enter the rating you'd give this store");
            string description = _validate.ValidateString("Enter the overall description of the experience:");
            //call the BL method that attempts to add a review to a store
            _reviewBL.AddReview(reviewable, new Review(rating, description));
        }

        private Store SearchStore()
        {
            Console.WriteLine("Enter the store details of the store you're looking for. Please note that this is a case sensitive app.");
            string name = _validate.ValidateString("Enter the store name: ");
            string city = _validate.ValidateString("Enter the city where the store is located");
            string state = _validate.ValidateString("Enter the state where the store is located at");
            try
            {
                Store foundStore = _storeBL.GetStore(new Store(name, city, state));
                Console.WriteLine("Store Found!");
                return foundStore;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Store not found :<. You can add it instead");
                return null;
            }
        }
    }
}