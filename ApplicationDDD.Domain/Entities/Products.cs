using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDDD.Domain.Entities
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ClientId { get; set; }
        public virtual Clients Client { get; set; }
        public virtual IEnumerable<Categories> Categories { get; set; }
    }
}
