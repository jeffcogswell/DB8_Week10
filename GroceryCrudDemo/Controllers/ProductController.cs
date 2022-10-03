using Microsoft.AspNetCore.Mvc;
using GroceryCrudDemo.Models;

namespace GroceryCrudDemo.Controllers
{
    public class ProductController : Controller
    {
        // List all products
        public IActionResult Index()
        {
            // Instead of saving the product list into a variable
            // and passing that variable, let's just put the
            // call right into View(model).
            return View(DAL.GetAllProducts());
        }

        // Display detail for a single product
        public IActionResult Detail(int id)
        {
            return View(DAL.GetOneProduct(id));
        }


        // Add a product requires two routes
        //   1. A route to send the form to the browser
        //   2. A route the browser calls when the form is submitted

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult Add(Product prod)
        {
            DAL.InsertProduct(prod);
            return Redirect("/product");
        }

        // Delete a product
        // This one won't return a view. Instead it will redirect
        // back to the index /product
        public IActionResult Delete(int id)
        {
            DAL.DeleteProduct(id);
            return Redirect("/product");
        }

        // Edit a product needs two routes
        //   1. A route to send the form (prepopulated) to the browser
        //   2. A route that does the update and redirects to index
        public IActionResult EditForm(int id)
        {
            return View(DAL.GetOneProduct(id));
        }

        public IActionResult SaveChanges(Product prod)
        {
            DAL.UpdateProduct(prod);
            return Redirect("/product");
        }
    }
}
