using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaAssist2._0.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminsManagement()
        {
            return View();
        }

        public ActionResult ManagersManagement()
        {
            return View();
        }
    }
}