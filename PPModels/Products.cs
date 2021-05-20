using System;

namespace PPModels
{

    class Products
    {
        public Products (int productId, string productName, int productQuantity, double productPrice)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductQuantity = productQuantity;
            this.ProductPrice = productPrice;

        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }

        public override string ToString()
        {
            return $"Name: {this.ProductName}";
        }
        // static void Main(string[] args)
        // {
                
        // }
    }
}