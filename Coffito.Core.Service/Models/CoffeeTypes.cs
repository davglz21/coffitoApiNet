using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffito.Core.Service.Models
{
    public class CoffeeTypes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public string Intensity { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
