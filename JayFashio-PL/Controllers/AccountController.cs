using JayFashio_M;
using JayFashio_PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayFashio_PL.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult createuser()
        {
            using (DataBase db = new DataBase())
            {
                var city = db.Cities.ToList();
                ViewBag.city = new SelectList(city, "Id", "CityName");


                return View();
            }
        }
        [HttpPost]
        public ActionResult createuser(User user)
        {

            if (ModelState.IsValid)
            {


                using (DataBase db = new DataBase())
                {
                    db.User.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Home");

                }

            }
            else
            {
                using (DataBase db = new DataBase())
                {
                    var city = db.Cities.ToList();
                    ViewBag.city = new SelectList(city, "Id", "CityName");

                }
            }
            return View();

        }


        public ActionResult login()
        {

            return View();
        }
        [HttpPost]


        public ActionResult login(userModel model)
        {
            using (DataBase db = new DataBase())
            {

                var user = db.User.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.Email == model.Email);
                if (user != null)
                {
                    Session["isuser"] = true;

                    return RedirectToAction("Home");
                }
            }
            return View();
        }


        public ActionResult logout()
        {
            Session["isuser"] = false;
            return RedirectToAction("Home");
        }


    }
}
