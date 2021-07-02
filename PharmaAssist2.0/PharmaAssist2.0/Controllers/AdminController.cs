using PharmaAssist2._0.Repository;
using PharmaAssist2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace PharmaAssist2._0.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AdminsManagement()
        {
            AdminRepository ar = new AdminRepository();
            var admins = ar.GetAll();
            return View(admins);
        }

        [HttpGet]
        public ActionResult ApproveLoginAdmin(int id)
        {
            LoginRepository lr = new LoginRepository();
            lr.UpdateLoginStatus(id, 1);
            return RedirectToAction("AdminsManagement");
        }

        public ActionResult RejectLoginAdmin(int id)
        {
            LoginRepository lr = new LoginRepository();
            lr.UpdateLoginStatus(id, 2);
            return RedirectToAction("AdminsManagement");
        }

        [HttpGet]
        public ActionResult GetAdminsByName(string id)
        {
            AdminRepository ar = new AdminRepository();
            var admins = ar.GetAdminsByName(id);
            return this.Json(admins, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ManagersManagement()
        {
            return View();
        }
    }
}