using System;
using System.Collections.Generic;

#nullable disable

namespace PPBL.Entities
{
    public partial class Sauce
    {
        public int Id { get; set; }
        public string SauceName { get; set; }
        public string SauceTemp { get; set; }
        public double SaucePrice { get; set; }
    }
}
