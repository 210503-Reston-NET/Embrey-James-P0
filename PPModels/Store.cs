
// using System;
// using System.Collections.Generic;
// using System.Text.RegularExpressions;

// namespace PPModels
// {
//     /// <summary>
//     /// This store sells hot sauce.
//     /// </summary>
//     public class Store
//     {
//         private string _city;
//         public Store(string name, string city, string state)
//         {
//             this.Name = name;
//             this.City = city;
//             this.State = state;
//         }
//         public Store()
//         {

//         }

//         public Store(int id, string name, string city, string state) : this(name, city, state)
//         {
//             this.Id = id;
//         }
//         public int Id { get; set; }
//         ///<summary>
//         /// Hello, and welcome to Patrick's Peppers! We sell an assortment of Hot Sauces to spice up your life. 
//         ///</summary>
//         /// <value></value>
//         public string PatricksPeppers { get; set; }
//         /// <summary>
//         /// This describes the location
//         /// </summary>
//         /// <value></value>
//         public string City
//         {
//             get { return _city; }
//             set
//             {
//                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) throw new Exception("City cannot have numbers!");
//                 _city = value;
//             }
//         }
//         public string State { get; set; }
//         /// <summary>
//         /// This contains the review of a particular restaurant
//         /// </summary>
//         /// <value></value>
//         ///public List<> Reviews { get; set; }
//         public override string ToString()
//         {
//             return $" Name: {Name} \n Location: {City}, {State}";
//         }
//         public bool Equals(Store store)
//         {
//             return this.Name.Equals(restaurant.Name) && this.City.Equals(restaurant.City) && this.State.Equals(restaurant.State);
//         }


//     }
// }