using PharmaAssist2._0.Models;
using PharmaAssist2._0.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PharmaAssist2._0.Controllers
{
    public class LoginController : Controller
    {
        LoginRepository contex = new LoginRepository();
        // GET: Lgin
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Login P)
        {
            Login valid = contex.Getregistared(P.Email);
            if (valid!=null)
            {
                ViewData["valid-msg"] = "This Email already Used";
                return RedirectToAction("Registration");
            }
            else
            {

                if (P.Type == "Doctor")
                {
                    contex.Insert(P);
                    Session["regemail"] = P.Email.ToString();
                    return RedirectToAction("Create", "Doctor", new { area = "" }); 
                }
                else if (P.Type == "Consumer")
                {
                    contex.Insert(P);
                    Session["regemail"] = P.Email.ToString();
                    return RedirectToAction("Doctor/Create");

                }
                else
                {
                    ViewData["Email"] = P.Email;
                    ViewData["valid-msg"] = "Please Select a Type";
                    return RedirectToAction("Registration");
                }
            }

        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}