using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.DTO.Product
{
    public class OrderGetDto
    {
        public List<ProductGetDto> Products { get; set; }
    }
}
