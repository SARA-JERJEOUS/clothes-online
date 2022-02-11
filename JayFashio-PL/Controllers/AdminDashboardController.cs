using JayFashio_M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayFashio_PL.Controllers
{
    public class AdminDashboardController : Controller
    {
        // GET: AdminDashboard
        public ActionResult Dashboard()
        {
            return View();
        }


        [HttpGet]
        public ActionResult CreateItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateItem(Item newItem)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User newUser)
        {
            using(DataBase db = new DataBase())
            {
                db.User.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet]
        public ActionResult CreateImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateImage(Image newImage)
        {
            return View();
        }
        ////
        public ActionResult EditItems()
        {
            return View();
        }

        public ActionResult EditUsers()
        {
            return View();
        }

        public ActionResult EditImages()
        {
            return View();
        }

    }
}