using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PPModels
{
    public class Orders
    {
        public Orders (int orderId, int orderQuantity, int orderNumber, double orderTotal)
        {
            this.OrderId = orderId;
            this.OrderQuantity = orderQuantity;
            this.OrderNumber = orderNumber;
            this.OrderTotal = orderTotal;
        }

        public int OrderId { get; set; }
        public int OrderQuantity { get; set; } = 1;

        public int OrderNumber { get; set; }

        public double OrderTotal {get; set; }

        public override string ToString()
        {
            return $"Name: {this.OrderQuantity}";
        }
        // static void Main(string[] args)
        // {
                
        // }
    }
}