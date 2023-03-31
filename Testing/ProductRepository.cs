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
            return _connection.Query<Product>("SELECT * FROM actor;");

            //return _connection.Query<Product>("SELECT * FROM actor;");
        }
        public Product GetProduct(int id)
        {

            //return _connection.QuerySingle<Product>("SELECT * FROM actor WHERE id = @id",
            return _connection.QuerySingle<Product>("SELECT * FROM actor WHERE id = @id",
                new { id = id });
        }
        public void UpdateProduct(Product product) //Not finished as of 3-24-23
        {
            _connection.Execute("UPDATE actor SET NAME = @name, AGE = @age, SEXID = @sexid, RACEID = @raceid, CLASSID = @classid, bio = @bio  WHERE id = @id",
                new { name = product.name, age = product.age, sexid = product.sexid, raceid = product.raceid, classid = product.classid, bio = product.bio, id = product.id });
        }
        public void InsertProduct(Product productToInsert)
        {
            _connection.Execute("INSERT INTO actor (id, NAME, AGE, SEXID, RACEID, CLASSID, BIO) VALUES (@id, @name, @age, @sexid, @raceid, @classid, @bio);",
                new { id = productToInsert.id, name = productToInsert.name, age = productToInsert.age, sexid = productToInsert.sexid, raceid = productToInsert.raceid, classid = productToInsert.classid, bio = productToInsert.bio });
        }
        public IEnumerable<Sex> GetSexes()
        {
            return _connection.Query<Sex>("SELECT * FROM sex;");
        }
        public IEnumerable<Heritage> GetRaces()
        {
            return _connection.Query<Heritage>("SELECT * FROM heritage;");
        }
        public IEnumerable<Archetype> GetJobs()
        {
            return _connection.Query<Archetype>("SELECT * FROM archetype;");
        }
        public Product AssignList()
        {
            var product = new Product();

            var categoryList = GetSexes();
            product.sex = categoryList;
            var categoryList2 = GetRaces();
            product.heritage = categoryList2;
            var categoryList3 = GetJobs();
            product.archetype = categoryList3;
            return product;
        }
        public void DeleteProduct(Product product)
        {
            _connection.Execute("DELETE FROM actor WHERE id = @id;",
                                       new { id = product.id });
        }
        public void OrganizeProduct(Product product)
        {
            _connection.Execute("UPDATE actor SET id = @id2 WHERE actor.id = @id",
                new { id2 = product.id - 1, id = product.id });
        }
        public string DisplayGender(int sex)
        {
            if (sex == 0) return "Male";
            if (sex == 1) return "Female";
            return "Other";
        }
    }
}
