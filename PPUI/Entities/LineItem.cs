﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PPUI.Entities
{
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public int? LineProductId { get; set; }
        public int? LineOrderId { get; set; }
        public int? LineQuantityId { get; set; }

        public virtual Product LineProduct { get; set; }
    }
}
