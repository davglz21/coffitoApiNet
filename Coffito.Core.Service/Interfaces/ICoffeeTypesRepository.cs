using Coffito.Core.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffito.Core.Service.Interfaces
{
    public interface ICoffeeTypesRepository: IDisposable
    {
        Task<List<CoffeeTypes>> GetCoffeeTypesAsync();
    }
}
