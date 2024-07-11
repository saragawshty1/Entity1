using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class product
    {
        public int productId { get; set; }
        public string ? Name { get; set; }
        public double Quantity{ get; set; }
        public int	Price{ get; set; }
        public int	SalesId{ get; set; }
        public string ? Description { get; set; }
        public List<Sales> Sales { get; set; }

    }
}
