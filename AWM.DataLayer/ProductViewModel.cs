using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.DataLayer
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal ListPrice { get; set; }
    }
}
