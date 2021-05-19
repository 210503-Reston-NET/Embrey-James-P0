using System;
using System.Collections.Generic;

#nullable disable

namespace PPDL.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
    }
}
