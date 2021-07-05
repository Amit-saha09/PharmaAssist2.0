﻿using PharmaAssist2._0.Repository;
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
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult AdminsManagement()
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                AdminRepository ar = new AdminRepository();
                var admins = ar.GetAll();
                return View(admins);
            }
        }

        [HttpGet]
        public ActionResult ApproveLoginAdmin(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lr = new LoginRepository();
                lr.UpdateLoginStatus(id, 1);
                return RedirectToAction("AdminsManagement");
            }
        }

        [HttpGet]
        public ActionResult RejectLoginAdmin(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lr = new LoginRepository();
                lr.UpdateLoginStatus(id, 2);
                return RedirectToAction("AdminsManagement");
            }
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
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ManagerRepository mr = new ManagerRepository();
                var managers = mr.GetAll();
                return View(managers);
            }
        }

        [HttpGet]
        public ActionResult ApproveLoginManager(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lm = new LoginRepository();
                lm.UpdateLoginStatus(id, 1);
                return RedirectToAction("ManagersManagement");
            }
        }

        [HttpGet]
        public ActionResult RejectLoginManager(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lm = new LoginRepository();
                lm.UpdateLoginStatus(id, 2);
                return RedirectToAction("ManagersManagement");
            }
        }

        [HttpGet]
        public ActionResult DoctorsManagement()
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                DoctorRepository dr = new DoctorRepository();
                var doctors = dr.GetAll();
                return View(doctors);
            }

        }

        [HttpGet]
        public ActionResult ApproveLoginDoctor(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository ld = new LoginRepository();
                ld.UpdateLoginStatus(id, 1);
                return RedirectToAction("DoctorsManagement");
            }
        }

        [HttpGet]
        public ActionResult RejectLoginDoctor(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lm = new LoginRepository();
                lm.UpdateLoginStatus(id, 2);
                return RedirectToAction("DoctorsManagement");
            }
        }

        [HttpGet]
        public ActionResult DeliverymensManagement()
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                DeliveryManRepository dmr = new DeliveryManRepository();
                var deliverymens = dmr.GetAll();
                return View(deliverymens);
            }

        }

        [HttpGet]
        public ActionResult ApproveLoginDeliverymen(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository ldm = new LoginRepository();
                ldm.UpdateLoginStatus(id, 1);
                return RedirectToAction("DeliverymensManagement");
            }
        }

        [HttpGet]
        public ActionResult RejectLoginDeliverymen(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lm = new LoginRepository();
                lm.UpdateLoginStatus(id, 2);
                return RedirectToAction("DeliverymensManagement");
            }
        }

        [HttpGet]
        public ActionResult ConsumersManagement()
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ConsumerRepository dc = new ConsumerRepository();
                var consumers = dc.GetAll();
                return View(consumers);
            }

        }

        [HttpGet]
        public ActionResult ApproveLoginConsumer(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository ld = new LoginRepository();
                ld.UpdateLoginStatus(id, 1);
                return RedirectToAction("ConsumersManagement");
            }
        }

        [HttpGet]
        public ActionResult RejectLoginConsumer(int id)
        {
            if (Session["logged_id"] == null || Session["logged_type"] == null || !Session["logged_type"].Equals("Admin"))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                LoginRepository lm = new LoginRepository();
                lm.UpdateLoginStatus(id, 2);
                return RedirectToAction("ConsumersManagement");

            }
        }
    }
}