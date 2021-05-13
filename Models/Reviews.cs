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
                if (_rating < 0)
                {
                    throw new Exception("Rating should be between zero and five stars.");
                }
                if (_rating > 5)
                {
                    throw new Exception("Rating should be between zero and five stars.");
                }
                _rating = value;
            }
        }
        /// <summary>
        /// Verbose description of store experience. 
        /// </summary>
        /// <value></value>
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