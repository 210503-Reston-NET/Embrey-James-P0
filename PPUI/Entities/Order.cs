using System;
using System.Collections.Generic;

#nullable disable

namespace PPUI.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderNumber { get; set; }
        public double OrderTotal { get; set; }
        public string OrderLocation { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
