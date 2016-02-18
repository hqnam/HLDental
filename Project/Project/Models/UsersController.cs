using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Models
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string taikhoan = f["txtTaiKhoan"].ToString();
            string matkhau = f["txtMatKhau"].ToString();
            User us= 
        }
    }
}