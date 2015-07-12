using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Czechicoach.Models;

namespace Czechicoach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = ApplicationDbContext.Create();
            var coaches = db.Coaches;
            
            return View(coaches);
        }

        public ActionResult New()
        {
            var coach = new Coach();
            return View(coach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New([Bind(Include = "FirstName,LastName,Email,Location")] Coach coach)
        {
            var db = ApplicationDbContext.Create();
            db.Coaches.Add(coach);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            var db = ApplicationDbContext.Create();
            var coach = db.Coaches.Find(id);
            return View(coach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Location")] Coach coach)
        {
            var db = ApplicationDbContext.Create();
            db.Entry(coach).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Destroy(Guid id)
        {
            var db = ApplicationDbContext.Create();
            var coach = db.Coaches.Find(id);
            db.Coaches.Remove(coach);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}