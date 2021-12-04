using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var discounts = db.discounts.Include(p => p.Type_Discount);
            return View(discounts.ToList());
        }

        public async Task<IActionResult> Create()
        {
            SelectList types = new SelectList(db.type_Discount, "ID", "Name_type");
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
            if (discount.Quantity <= 0) discount.Quantity = 999;
            discount.End_date = DateTime.Now.AddDays(Convert.ToInt32(discount.End_date)).ToString("dd.MM.yyyy");
            //Добавляем игрока в таблицу
            db.discounts.Add(discount);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); 
            }
            // Находим в бд футболиста
            Discounts discount = db.discounts.Find(id);
            if (discount != null)
            {
                // Создаем список команд для передачи в представление
                SelectList types = new SelectList(db.type_Discount, "ID", "Name_type", discount.Type_DiscountID);
                ViewBag.Type_Discount = types;
                discount.End_date = ((Convert.ToDateTime(discount.End_date) - DateTime.Now).Days + 1).ToString();

                return View(discount);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Discounts discount)
        {
            discount.End_date = DateTime.Now.AddDays(Convert.ToInt32(discount.End_date)).ToString("dd.MM.yyyy");
            db.Entry(discount).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Discounts discount = new Discounts { ID = id };
            db.Entry(discount).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
