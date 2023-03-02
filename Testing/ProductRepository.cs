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
        public Product GetProduct(int id)
        {
            return _connection.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }
        public void UpdateProduct(Product product)
        {
            _connection.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.Name, price = product.Price, id = product.ProductID });
        }

    }
}
