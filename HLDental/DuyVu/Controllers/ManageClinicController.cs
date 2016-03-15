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
        HL_DentalEntities1 db = new HL_DentalEntities1();
        public ActionResult Index()
        {
            return View(db.Staffs.ToList());
        }

        public ActionResult Create(Staff stf)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(stf);
                //db.SaveChanges();
            }
            return View();
        }

        public ActionResult Details(string ID)
        {
            Staff stf = db.Staffs.SingleOrDefault(n => n.IDStaff == ID);
            if (stf == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(stf);
        }


        public ActionResult Delete(string ID)
        {
            Staff stf = db.Staffs.SingleOrDefault(n => n.IDStaff == ID);
            if (stf == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(stf);
        }
    }
}