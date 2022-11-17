using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiKtTesstV3.Models
{
    public class Hang
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHang { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
    }
}