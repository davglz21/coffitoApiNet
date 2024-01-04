using Coffito.Core.Service.Context;
using Coffito.Core.Service.Interfaces;
using Coffito.Core.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffito.Core.Service.Repositories
{
    public class CoffeeTypesRepository : ICoffeeTypesRepository, IDisposable
    {

        private CoffitoDbContext _coffeeTypesContext;

        public CoffeeTypesRepository(CoffitoDbContext coffeeTypesContext)
        {
            _coffeeTypesContext = coffeeTypesContext;
        }

        public Task<List<CoffeeTypes>> GetCoffeeTypesAsync()
        {
            try
            {
                return _coffeeTypesContext.CoffeeTypes.ToListAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public void Dispose()
        {
            //Do nothing
        }
    }
}
