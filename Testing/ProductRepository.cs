using Dapper;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository: IProductRepository
    {
        private readonly IDbConnection _connection;
        public ProductRepository(IDbConnection conn)
        {
            _connection = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
