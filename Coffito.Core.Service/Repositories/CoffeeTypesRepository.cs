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

        public async Task<List<CoffeeTypes>> GetCoffeeTypesAsync()
        {
            try
            {
                return await _coffeeTypesContext.CoffeeTypes.ToListAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public async Task<CoffeeTypes> GetCoffeeTypesByIdAsync(int id)
        {
            try
            {
                var coffeeInfo = await _coffeeTypesContext.CoffeeTypes.SingleOrDefaultAsync(x => x.ID == id);
                if(coffeeInfo != null) 
                {
                    return coffeeInfo;
                }
                return new CoffeeTypes();
            }
            catch (Exception ex)
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
