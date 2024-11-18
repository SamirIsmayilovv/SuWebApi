using App.Service.DTO.Product;
using App.Service.Responses;
using App.Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IExternalApiService _service;
        public ProductsController(IExternalApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            ResultResponse response= await _service.GetDataFromApiAsync("https://su.betasayt.com/api/system/orders.php/?key=vf6rq1dt75kizl93bs284hugpxenmyca&begin=01.10.2024&finish=31.10.2024");
            return StatusCode(200, response);
        }
    }
}
