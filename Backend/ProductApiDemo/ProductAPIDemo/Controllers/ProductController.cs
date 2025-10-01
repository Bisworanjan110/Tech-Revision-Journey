using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPIDemo.Models;

namespace ProductAPIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 75000, Category = "Electronics" },
            new Product { Id = 2, Name = "Chair", Price = 2500, Category = "Furniture" },
            new Product { Id = 3, Name = "Pen", Price = 10, Category = "Stationery" }
        };

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            return Json(products);
        }
        [HttpGet]
        public JsonResult GetProductById(int id)
        {
            string message = string.Empty;
            Product product = new Product();
            product = products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                message = "Product not found!";
                return Json(message);
            }
            return Json(product); ;
        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            bool success = false;
            try
            {
                product.Id = products.Max(p => p.Id) + 1;
                products.Add(product);
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return Json(success);
        }

        [HttpPut]
        public JsonResult UpdateProduct(Product updateProduct)
        {
            bool status = false;
            try
            {
                var product = products.FirstOrDefault(p => p.Id == updateProduct.Id);
                if(product == null)
                {
                    status = false;
                }
                else
                {
                    product.Name = updateProduct.Name;
                    product.Price = updateProduct.Price;
                    product.Category = updateProduct.Category;
                    status = true;
                }
            }
            catch (Exception)
            {
                status = false;
            }
            return Json(status);
        }
        [HttpDelete]
        public JsonResult DeleteProduct(int id)
        {
            bool status = false;
            try
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if(product == null)
                {
                    status = false;
                }
                else
                {
                    products.Remove(product);
                    status = true;
                }
            }
            catch (Exception)
            {
                status=false;
            }
            return Json(status);
        }

    }
}
