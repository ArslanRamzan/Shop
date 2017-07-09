using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _41.Models;
namespace _41.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Admin()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }
        [ActionName("LogIn")]
        [HttpPost]
        public ActionResult LogIn(LogIn login)
        {
            if (DB.Validate(login.Email, login.password))
            {
                Session["login"] = login.Email;
                return View("Admin");
            }
                
            else
                return View("LogIn");
        }
        public ActionResult Product_M()
        {
            if(Session["login"]==null)
            {
                return Redirect("LogIn");
            }
            return View();
        }

        public ActionResult Product_W()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }
        public ActionResult Product_K()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }
        public ActionResult Contact()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult checkout()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }
        public ActionResult press()
        {
            
            return View();
        }
        public ActionResult terms()
        {
            return View();
        }
        public ActionResult single()
        {
            if (Session["login"] == null)
            {
                return Redirect("LogIn");
            }
            return View();
        }
    }
}