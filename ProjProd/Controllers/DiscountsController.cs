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
    public class DiscountsController : Controller
    {
        private DBContext db;
        public DiscountsController(DBContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            //var discounts = db.discounts.Include(p => p.Type_Discount).Where("Type_Disccountid_type == Type_discount.id_type");
            //return View(discounts.ToList());
        }

        public async Task<IActionResult> Create()
        {
            SelectList types = new SelectList(db.type_Discount, "id_type", "Name_type");
            ViewBag.Type_Discounts = types;
            return View();
        }

        [HttpGet]
        public IActionResult AddDiscount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDiscount(Discounts discount)
        {
            Random rnd = new Random();
            Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string name_disc = string.Empty;
            for (int i = 0; i<5 ; i++)
                name_disc += pwdChars[rnd.Next(0, 25)];
            discount.Name_discount = name_disc;
            discount.End_date = DateTime.Now.AddDays(Convert.ToInt32(discount.End_date)).ToString("dd.MM.yyyy");
            //Добавляем игрока в таблицу
            db.discounts.Add(discount);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
    }
}
