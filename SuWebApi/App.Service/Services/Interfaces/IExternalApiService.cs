using App.Service.DTO.Product;
using App.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.Interfaces
{
    public interface IExternalApiService
    {
        public Task<ResultResponse> GetDataFromApiAsync(string url);
    }
}
