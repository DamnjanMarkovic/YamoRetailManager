using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamoDesktopUI.Library.Models
{
    public class CartItemModel
    {
        public ProductModel Product { get; set; }
        public int QuantityInCart { get; set; }

        public string DislayText
        {
            get
            {
                return $"{Product.ProductName }({QuantityInCart})";
            }
        }
    }
}
