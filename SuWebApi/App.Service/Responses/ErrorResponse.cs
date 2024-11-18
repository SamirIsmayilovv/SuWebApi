using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Responses
{
    public class ErrorResponse:Exception
    {
        public string Status { get; set; }
        public string Error { get; set; }   
    }
}
