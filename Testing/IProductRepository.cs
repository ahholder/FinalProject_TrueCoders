using System.Collections;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        //Unable to use Testing.Models, so used "General" by adding System.Collections.Generic - Likely Resolved
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
