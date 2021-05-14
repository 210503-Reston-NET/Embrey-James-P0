using System;
using System.Globalization;
using System.Collections.Generic;


namespace Models
{
    public class Customer
    {
        /// <summary>
        /// Holds information for customers.
        /// </summary>
        /// <param name="args"></param>
        public Customer (string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This page is used for adding a customer!");
        }
    }
}