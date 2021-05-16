using System;
using System.Collections.Generic;

#nullable disable

namespace PPBL.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime AddDate { get; set; }
    }
}
