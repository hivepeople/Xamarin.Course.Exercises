using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFiltersAndHandlers.Models;

namespace WebApiFiltersAndHandlers.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly Product[] products = new[]
        {
            new Product { Id = 1, Name = "Shampoo" },
            new Product { Id = 2, Name = "Næsespray" }
        };

        public IList<Product> GetAllProducts()
        {
            Debug.WriteLine("We are now in the controller method");
            return products;
        }
    }
}
