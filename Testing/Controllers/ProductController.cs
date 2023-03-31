using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Testing.Models;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }
        public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            if (prod == null)
            {
                return View("ProductNotFound");
            }

            return View(prod);
        }
        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.id });
        }
        //View EmptyRazor must be the same name as the method in the controller
        public IActionResult InsertProduct()
        {
            var prod = repo.AssignList();


            return View(prod);
        }
        public IActionResult InsertProductToDatabase(Product productToInsert)
        {
            var currentList = repo.GetAllProducts();
            productToInsert.id = currentList.ToArray().Length;
            repo.InsertProduct(productToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(Product product)
        {
            var organizePoint = product.id;

            //Delete Actor
            repo.DeleteProduct(product);

            //Organize Actors
            var currentList = repo.GetAllProducts();
            foreach (var actor in repo.GetAllProducts())
            {
                if (actor.id > organizePoint) repo.OrganizeProduct(actor);
            }

            //Final
            return RedirectToAction("Index");
        }

    }
}
