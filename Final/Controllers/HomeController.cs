using Final.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        Final_ProjectEntities1 objDB = new Final_ProjectEntities1();
        public ActionResult Index()
        {
            var listPD = objDB.products.ToList();
            return View(listPD);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(user _user)
        {
            if (ModelState.IsValid)
            {
                var check = objDB.users.FirstOrDefault(s => s.users_email == _user.users_email);
                if (check == null)
                {
                    objDB.Configuration.ValidateOnSaveEnabled = false;
                    objDB.users.Add(_user);
                    objDB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(user _user)
        {
            if (ModelState.IsValid)
            {
                var data = objDB.users.Where(s => s.users_email.Equals(_user.users_email) && s.users_password.Equals(_user.users_password)).ToList();
                if (data.Count() > 0)
                {
                    Session["FullName"] = data.FirstOrDefault().users_fullname;
                    Session["Email"] = data.FirstOrDefault().users_email;
                    Session["idUser"] = data.FirstOrDefault().users_id;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }
    }
}