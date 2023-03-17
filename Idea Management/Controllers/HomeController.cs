using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Idea_Management.Models;

namespace Idea_Management.Controllers
{
    public class HomeController :
        Controller
    {
        private ApplicationDbContext db = new
            ApplicationDbContext();
        public ActionResult Index()
        {
            return View(db.Ideas.ToList());
        }
    }
}