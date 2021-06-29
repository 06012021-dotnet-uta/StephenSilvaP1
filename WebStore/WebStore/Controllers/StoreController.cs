using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly P1DBContext _db;

        public StoreController(P1DBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Store> objList = _db.Store;
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
        public IActionResult Create(Store obj)
        {
            _db.Store.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
