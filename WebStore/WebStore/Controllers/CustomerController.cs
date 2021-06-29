using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly P1DBContext _db;

        public CustomerController(P1DBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Customer> objList = _db.Customer;
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
        public IActionResult Create(Customer obj)
        {
            _db.Customer.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
