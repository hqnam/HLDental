using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class ManageClinicController : Controller
    {
        // GET: ManageClinic
        QLPhongKhamEntities1 db = new QLPhongKhamEntities1();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        //Create User
        [HttpGet]
        public ActionResult Create()
        {
            //ViewBag.IDGroup = db.Users.ToList();
            //ViewBag.IDGroup = db.GroupUsers.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(User us)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(us);
                db.SaveChanges();
            }
            return View();
        }

        //Edit User
        //[HttpPost]
        //public ActionResult Edit(int id)
        //{
        //    User us = db.Users.SingleOrDefault(n => n.ID = id);

        //    return View();
        //}
    }
}