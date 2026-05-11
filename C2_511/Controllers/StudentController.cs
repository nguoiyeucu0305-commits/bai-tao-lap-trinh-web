using C2_511.Models;
using Microsoft.AspNetCore.Mvc;

namespace C2_511.Controllers
{ 
    public class StudentController : Controller
    {
        private static List<Student> RegisteredStudents = new List<Student>();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowKQ(Student student)
        {
            // Thêm sinh viên vào danh sách
            RegisteredStudents.Add(student);
            // Đếm số lượng sinh viên cùng chuyên ngành
            int sameMajorCount = RegisteredStudents.FindAll(s => s.ChuyenNganh == student.ChuyenNganh).Count;

            // Truyền dữ liệu sang View ShowKQ
            ViewBag.MSSV = student.MSSV;
            ViewBag.HoTen = student.HoTen;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.SameMajorCount = sameMajorCount;
            return View();
        }
    }
}
