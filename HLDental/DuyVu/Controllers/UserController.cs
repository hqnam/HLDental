using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuyVu.Models;

namespace DuyVu.Controllers
{
    public class UserController : Controller
    {
        HL_DentalEntities1 db = new HL_DentalEntities1();
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            string user = f.Get("txtUser").ToString();
            string pwd = f.Get("txtPwd").ToString();
            Staff stf = db.Staffs.SingleOrDefault(n => n.Username == user && n.Password == pwd);
            if (stf != null)
            {
                ViewBag.Thongbao = "Success";
                Session["Username"] = stf;
                return View();
            }
            ViewBag.Thongbao = "Failed";
            return View();
        }        
    }
}