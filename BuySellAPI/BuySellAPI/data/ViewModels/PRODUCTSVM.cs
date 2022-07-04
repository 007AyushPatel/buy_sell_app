using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySellAPI.data.ViewModels
{
    public class PRODUCTSVM
    {
        public long UserMobile { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public string ProductLocation { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageUrl{get; set; }
        public string Privacy { get; set; }
    }
}
