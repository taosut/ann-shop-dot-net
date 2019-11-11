﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ann_shop_server.Models
{
    public class ProductRelatedModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public string avatar { get; set; }
        public int badge { get; set; }
    }
}