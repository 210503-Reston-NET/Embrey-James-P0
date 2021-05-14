using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PPModels
{
    public class Store
    {
        
        private string _city;
        public Store(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }
        public Store()
        {

        }
        // Constructor chaining
        public Store(int id, string name, string city, string state) : this(name, city, state)
        {
            this.Id = id;
        }
        public int Id { get; set; }
        /// <summary>
        /// Describe the name of your store
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Describe the store location
        /// </summary>
        /// <value></value>
        public string City
        {
            get { return _city; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) throw new Exception("City cannot have numbers!");
                _city = value;
            }
        }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string State { get; set; }
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
        public bool Equals(Store store)
        {
            return this.Name.Equals(store.Name) && this.City.Equals(store.City) && this.State.Equals(store.State);
        }
    }
}