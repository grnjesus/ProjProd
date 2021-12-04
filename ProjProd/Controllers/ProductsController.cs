using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjProd.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjProd.Controllers
{
    public class ProductsController : Controller
    {
        private DBContext db;

        public ProductsController(DBContext context)
        {
            this.db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var source = db.products.Include(x => x.Photos_Prod);
            return View(source);
        }
    }
}
