using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly P1DBContext _db;

        public ProductController(P1DBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Product;
            return View(objList);
        }
        // GET CREATE
        public IActionResult Create()
        {
            return View();
        }
        // POST - CREAT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            _db.Product.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
