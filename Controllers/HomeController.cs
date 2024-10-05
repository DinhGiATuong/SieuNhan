using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult AddProduct(string productName, decimal productPrice)
        {
            // Thêm logic để lưu sản phẩm vào cơ sở dữ liệu hoặc danh sách sản phẩm
            // Sau khi thêm thành công, chuyển hướng lại trang Admin

            return RedirectToAction("Admin");
        }
        [HttpPost]
        public IActionResult UpdateAdmin(AdminInfo adminInfo)
        {
            //logic đổi thông tin
            return View();
        }
        public IActionResult Admin()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = "HD001", CustomerName = "Iphone 16", PhoneNumber = "100", TotalAmount = 100.00M, Status = "Còn hàng" },
                new Order { OrderId = "HD002", CustomerName = "Samsung", PhoneNumber = "150", TotalAmount = 150.00M, Status = "Hết hàng" }
            };

            var adminInfo = new AdminInfo
            {
                Username = "admin",  // Thông tin quản trị viên
                Email = "admin@example.com",
                Role = "Admin"
            };

            var model = new AdminViewModel
            {
                Orders = orders,
                CurrentAdmin = adminInfo // Truyền thông tin quản trị viên vào model
            };

            return View(model);
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
