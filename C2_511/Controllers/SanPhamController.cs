using C2_511.Models;
using Microsoft.AspNetCore.Mvc;

namespace C2_511.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DanhSach()
        {
            ViewBag.MaSP = "001";
            ViewBag.TenSP = "Điện thoại Samsung Galaxy S23";
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanPham = new SanPhamViewModel()
            {
                TenSP = "Điện thoại thông minh",
                GiaBan = 112345567,
                AnhMoTa = "shopping.jpg"
            };
            return View(sanPham);
        }
    }
}
