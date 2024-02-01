using Coffito.Business.Service.Interfaces;
using Coffito.Core.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffitoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeTypesController : ControllerBase
    {
        private readonly ICoffeeTypesManager _coffeeTypesManager;

        public CoffeeTypesController(ICoffeeTypesManager coffeeTypesManager)
        {
            _coffeeTypesManager = coffeeTypesManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<CoffeeTypes>>> GetCoffeeTypes()
        {
            var tiposCafe = await _coffeeTypesManager.GetCoffeeTypesAsync();
            return Ok(tiposCafe);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CoffeeTypes>> GetCoffeeTypesById(int id)
        {
            var tiposCafe = await _coffeeTypesManager.GetCoffeeTypesByIdAsync(id);
            return Ok(tiposCafe);
        }
    }
}
