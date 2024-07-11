using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Sales
    {
        public int SalesId { get; set; }
        public string ?Name { get; set; }
        public DateTime Date { get; set; }
        public int productId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public product? product { get; set; }
        public Customer? Customer { get; set; }
        public Store? Store { get; set; }
    }
}
