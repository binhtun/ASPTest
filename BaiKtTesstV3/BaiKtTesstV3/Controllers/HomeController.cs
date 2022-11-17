using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiKtTesstV3.Models;

namespace BaiKtTesstV3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cau2()
        {
            return View();
        }
        public ActionResult KetQua(Hang h)
        {
            if(h.SoLuong>=100)
            {
                h.ThanhTien = (h.SoLuong * h.DonGia )* 0.9;
            }
            else
            {
                h.ThanhTien = h.SoLuong * h.DonGia;
            }    
            return View(h);
        }

    }
}