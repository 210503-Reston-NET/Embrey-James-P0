using System;
using System.Collections.Generic;

#nullable disable

namespace PPDL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public int? OrderNumber { get; set; }

        public virtual Customer OrderNumberNavigation { get; set; }
    }
}
