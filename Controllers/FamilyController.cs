using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_net_core_mvc1.Data;
using asp_net_core_mvc1.Models;

namespace asp_net_core_mvc1.Controllers
{
    public class FamilyController : Controller
    {
        private readonly ApplicationDBContext db;
        public FamilyController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Family> familyList = db.Persons;

            return View(familyList);
        }
        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePerson(Family obj)
        {
            db.Persons.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
