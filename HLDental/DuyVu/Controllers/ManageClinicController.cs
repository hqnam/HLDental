using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuyVu.Models;

namespace Project.Controllers
{
    public class ManageClinicController : Controller
    {
        // GET: ManageClinic
        HL_DentalEntities1 db = new HL_DentalEntities1();
        public ActionResult Index()
        {
            return View(db.Staffs.ToList());
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
        public ActionResult Create(Staff stf)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(stf);
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