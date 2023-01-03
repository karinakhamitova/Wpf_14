using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_14
{
     public class Product
    {
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
    }
    public enum ProductTypes
    {
        Food,
        Clothes,
        Electronics
    }

}
