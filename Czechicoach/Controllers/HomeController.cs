using System;
using System.Collections.Generic;
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
    }
}