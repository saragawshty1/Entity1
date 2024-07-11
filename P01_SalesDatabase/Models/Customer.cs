﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string ?Name { get; set; }
        public string ?Email { get; set; }
        public string ?CreaditCardNumber { get; set; }
        public int SalesId { get; set; }
        public List<Sales> Sales { get; set; }
    }
}
