﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ann_shop_server.Models
{
    public enum ProductSortKind
    {
        PriceAsc = 1,    // Gia tang dan
        PriceDesc = 2,    // Gia giam dan
        ModelNew = 3,    // Kieu moi nhat
        ProductNew = 4     // Hang moi ve
    }
}