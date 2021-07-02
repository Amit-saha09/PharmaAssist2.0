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

        [HttpGet]
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
            ManagerRepository mr = new ManagerRepository();
            var managers = mr.GetAll();
            return View(managers);
        }

        [HttpGet]
        public ActionResult ApproveLoginManager(int id)
        {
            LoginRepository lm = new LoginRepository();
            lm.UpdateLoginStatus(id, 1);
            return RedirectToAction("ManagersManagement");
        }

        [HttpGet]
        public ActionResult RejectLoginManager(int id)
        {
            LoginRepository lm = new LoginRepository();
            lm.UpdateLoginStatus(id, 2);
            return RedirectToAction("ManagersManagement");
        }

        [HttpGet]
        public ActionResult DoctorsManagement()
        {
            DoctorRepository dr = new DoctorRepository();
            var doctors = dr.GetAll();
            return View(doctors);
        }

        [HttpGet]
        public ActionResult ApproveLoginDoctor(int id)
        {
            LoginRepository ld = new LoginRepository();
            ld.UpdateLoginStatus(id, 1);
            return RedirectToAction("DoctorsManagement");
        }

        [HttpGet]
        public ActionResult RejectLoginDoctor(int id)
        {
            LoginRepository lm = new LoginRepository();
            lm.UpdateLoginStatus(id, 2);
            return RedirectToAction("DoctorsManagement");
        }
    }
}