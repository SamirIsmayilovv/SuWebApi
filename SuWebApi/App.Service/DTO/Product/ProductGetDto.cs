using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.DTO.Product
{
    public class ProductGetDto
    {
        public int order_quantity { get; set; }
        public decimal order_price { get; set; }
        public string order_product_name { get; set; }
    }
}
