using App.Service.DTO.Product;
using App.Service.Responses;
using App.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.Service.Services.Implementations
{
    public class ExternalApiSerice : IExternalApiService
    {
        private readonly HttpClient _httpClient;
        public ExternalApiSerice(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultResponse> GetDataFromApiAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            if (jsonString.Contains("error"))
                throw JsonSerializer.Deserialize<ErrorResponse>(jsonString);
            return JsonSerializer.Deserialize<ResultResponse>(jsonString);
        }

    }
}
