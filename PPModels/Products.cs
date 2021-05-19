using System;

namespace PPModels
{

    class Products
    {
        public Products (string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
        // static void Main(string[] args)
        // {
                
        // }
    }
}