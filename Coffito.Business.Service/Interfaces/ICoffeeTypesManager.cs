using Coffito.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffito.Business.Service.Interfaces
{
    public interface ICoffeeTypesManager
    {
        Task<List<CoffeeTypes>> GetCoffeeTypesAsync();
        Task<CoffeeTypes> GetCoffeeTypesByIdAsync(int id);
    }
}
