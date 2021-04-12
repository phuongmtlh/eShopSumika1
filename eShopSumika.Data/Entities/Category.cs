﻿using eShopSumika.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSumika.Data.Entities
{
    public class Category
    {
        public int id { get; set; }

        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
