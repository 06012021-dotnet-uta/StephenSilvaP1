using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly P1DBContext _db;

        public OrderController(P1DBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Order> objList = _db.Order;
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
        public IActionResult Create(Order obj)
        {
            _db.Order.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
