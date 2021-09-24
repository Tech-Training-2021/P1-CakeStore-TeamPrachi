using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProjectDemo.Models;


namespace MVCProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        CakeModel db = new CakeModel();
        public ActionResult Index()
        {

            return View(db.UserTbls.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserTbl user)
        {
            //if (ModelState.IsValid)
            //{
            //    db.UserTbls.Add(user);
            //    db.SaveChanges();
            //}
            //return RedirectToAction("Login");

            if (db.UserTbls.Any(x => x.userId == user.userId))

            {
                ViewBag.Notification = "UserID Already Exists";
                

                return View();
            }
            else
            {
                db.UserTbls.Add(user);
                db.SaveChanges();

                Session["userId"] = user.userId.ToString();
                Session["Username"] = user.fullName.ToString();
                return RedirectToAction("Login", "Home");
            }
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");

        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserTbl user)
        {
            if(user.userId=="Admin" && user.password=="123")
            {
                Session["Id"] = user.userId.ToString();
                return RedirectToAction("Modify");
            }
            var checklogin = db.UserTbls.Where(x => x.userId.Equals(user.userId) && x.password.Equals(user.password)).FirstOrDefault();
            if (checklogin != null)
            {
                Session["Id"] = user.userId.ToString();
                //Session["Username"] = user.fullName.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "Wrong username or password";
            }
            return View();

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


        public ActionResult AdminLogin()
        {
            string AdminId = "Rait123";
            int AdminPass = 321;
            return View();
        }
        public ActionResult Modify()
        {
            return View();
        }
    }
}