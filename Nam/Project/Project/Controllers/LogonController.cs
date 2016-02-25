using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class LogonController : Controller
    {
        QLPhongKhamEntities1 db = new QLPhongKhamEntities1();

        // GET: Logon
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost ]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(User us)
        {
            if (ModelState.IsValid)
            {
                // chèn dữ liệu vào bảng Users
                db.Users.Add(us);
                // lưu vào CSDL
                db.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string user = f.Get("txtTaiKhoan").ToString();
            string pwd = f.Get("txtMatKhau").ToString();
            User us = db.Users.SingleOrDefault(n => n.Name == user && n.Pwd == pwd);
            if(us != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["Username"] = us;
                return View();
            }
            ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng";
            return View();
        }
    }
}