using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazSegregation
{
    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product entiy)
        {
            //...
        }

        public void Delete(int entiy)
        {
            //...
        }

        public Product Retrieve(int id)
        {
            return new Product();
        }

        public IEnumerable<Product> RetrieveAll()
        {
            return new List<Product>();
        }

        public void Update(Product entiy)
        {
            //...
        }
    }
}
