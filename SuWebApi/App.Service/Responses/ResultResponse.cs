using App.Service.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Responses
{
    public class ResultResponse
    {
        public string Status { get; set; }
        public List<OrderGetDto> Result { get; set; }
    }
}
