using Coffito.Business.Service.Interfaces;
using Coffito.Core.Service.Interfaces;
using Coffito.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffito.Business.Service.Managers
{
    public class CoffeeTypesManager : ICoffeeTypesManager
    {
        private readonly ICoffeeTypesRepository _coffeeTypesRepository;

        public CoffeeTypesManager(ICoffeeTypesRepository coffeeTypesRepository)
        {
            _coffeeTypesRepository = coffeeTypesRepository;
        }

        public async Task<List<CoffeeTypes>> GetCoffeeTypesAsync()
        {
            return  await _coffeeTypesRepository.GetCoffeeTypesAsync(); 
        }

        public async Task<CoffeeTypes> GetCoffeeTypesByIdAsync(int id)
        {
            return  await _coffeeTypesRepository.GetCoffeeTypesByIdAsync(id); 
        }
    }
}
