﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        public string? Name { get; set; }
        public   int SalesId { get; set; }
        public List<Sales>Sales { get; set; }
    }
}