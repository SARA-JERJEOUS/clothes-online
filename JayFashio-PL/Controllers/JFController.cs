using JayFashio_M;
using JayFashio_PL.helper;
using JayFashio_PL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JayFashio_PL.Controllers
{
    public class JFController : Controller
    {

        public ActionResult sal()
        {
            using (DataBase db = new DataBase())
            {

                var list = db.Items.ToList();
                var x = db.Items.Where(n => n.Categorys.categoryname == "salary").ToList();

                return View(x);

            }


        }
        public ActionResult index()
        {
            using (DataBase db = new DataBase())
            {

                var list = db.Items.ToList();
                var x = db.Items.Where(n => n.Categorys.categoryname == "ManH").ToList();


                return View(x);

            }


        }


        public ActionResult manj()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var c = db.Items.Where(n => n.Categorys.categoryname == "Manj").ToList();


                return View(c);

            }


        }


        public ActionResult mant()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "Mant").ToList();


                return View(a);

            }


        }



        public ActionResult womh()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "womH").ToList();


                return View(a);

            }


        }

        public ActionResult womj()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "womj").ToList();


                return View(a);

            }


        }


        public ActionResult womsws()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "womsho").ToList();


                return View(a);

            }


        }

        public ActionResult womt()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "womt").ToList();


                return View(a);

            }


        }


        public ActionResult kt()
        {
            using (DataBase db = new DataBase())
            {


                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "kidt").ToList();


                return View(a);

            }


        }
        public ActionResult kh()
        {
            using (DataBase db = new DataBase())
            {



                var list = db.Items.ToList();
                var a = db.Items.Where(n => n.Categorys.categoryname == "kidH").ToList();


                return View(a);
            }



        }

        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

    }
       
}