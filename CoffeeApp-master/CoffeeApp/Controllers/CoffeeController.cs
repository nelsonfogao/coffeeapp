using Aplication.Domain.Dtos;
using Aplication.Domain.Models;
using Aplication.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeApp.Controllers
{
    [ApiController]
    [Route("v1")]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService _coffeeService;

        public CoffeeController(ICoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
        }
        [HttpGet("coffees")]
        public async Task<IActionResult> Get()
        {
            return Ok( await _coffeeService.GetAll() );
        }
        [HttpPost("calculate")]
        public async Task<IActionResult> Post(CreateRecomendationDto consumption)
        {
            return Ok(await _coffeeService.Calculate(consumption));
        }

    }
}
