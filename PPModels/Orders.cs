using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PPModels
{
    public class Orders
    {
        public Orders (int orderQuantity)
        {
            this.OrderQuantity = orderQuantity;
        }

        public int OrderQuantity { get; set; } = 1;

        public override string ToString()
        {
            return $"Name: {this.OrderQuantity}";
        }
        // static void Main(string[] args)
        // {
                
        // }
    }
}