using System;

namespace Models
{
    public class Reviews
    {
        private int _rating;
        /// <summary>
        /// Average rating of stores.
        /// </summary>
        /// <value></value>
        public int Rating
        {
            get { return _rating; }
            set
            {
                //Setting validation logic in properties
                if (_rating < 1)
                {
                    throw new Exception("Rating should be between one and five stars.");
                }
                if (_rating > 5)
                {
                    throw new Exception("Rating should be between one and five stars.");
                }
                _rating = value;
            }
        }

        public void Start()
        {
            // Add a review
            Review reviewable = SearchRestaurant();
            if (reviewable != null)
            {
                do
                {
                    Console.WriteLine($"Welcome to the review menu of Patrick's Peppers! What would you like to do?");
                    Console.WriteLine("[0] Add a review");
                    Console.WriteLine("[1] Go back");
                    string.input = Console.ReadLine();
                    switch (input)
                    {
                        case "0":
                            //Add review method
                            AddReviews(reviewable);
                            break;
                        case "1":
                            repeat = false;
                            Console.WriteLine("Going back to restaurant menu");
                            break;
                        default:
                            Console.WriteLine("Well, I don't know. Invalid input");
                            break;
                    }
                } while (repeat);
                
            }
            //if the restaurant was null just finish execution
            
        }



        private void AddReviews(Reviews revieable)
        {
            int rating = _validate.ValidateInt("Enter the rating you'd give this restaurant");
            string description = _validate.ValidateString("Enter overall description of experience:");
        }
        /// <summary>
        /// Verbose description of store experience. 
        /// </summary>
        /// <value></value>
        /// 
        
        private Reviews SearchReviews()
        {
            Console.WriteLine("Enter details of review your looking for. Please note this is a case-sensitive application");
            string name = _validate.ValidateString("Enter the review name");
            string city = _validate.ValidateString("Enter city for review");
            string state = _validate.ValidateString("Enter state for review");
            
            try
            {
                Reviews foundReview = _reviewBL.GetReview(new Reviews (name, city, state));
                Console.WriteLine(ex.Message);
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }
        }
        public Reviews(string description) 
        {
            this.Description = description;

        }
                public string Description { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }


    }
}