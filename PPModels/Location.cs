using System;
using System.Globalization;
using System.Collections.Generic;

namespace PPModels
{
    public class Location
    {
        /// <summary>
        /// Defines a store location
        /// </summary>
        /// <param name="args"></param>
        public Location (string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public string Name { get; set; } = "Patrick's Peppers";
        public string Address { get; set; } = "123 Spicy Drive, Harrisburg, PA, 17015";

        public override string ToString()
        {
            return $"Name: {this.Name} \nAddress: {this.Address}";
        }
        // static void Main(string[] args)
        // {
            
        // }
    }
}