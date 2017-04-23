using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartHouse.Web.Models;

namespace SmartHouse.Web.Controllers
{
    [RoutePrefix("Arduino")]
    public class ArduinoPageController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: ArduinoPage
        public ActionResult Index()
        {
            var model = db.ArduinoDataModelPosts.ToList();

            return View(model);
        }
    }
}