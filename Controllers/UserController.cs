using Microsoft.AspNetCore.Mvc;
using ASM.Models;


public class UserController : Controller
{
    public IActionResult DangNHap()
    {
        return View();
    }
    public IActionResult DangKy()
    {
        return View();
    }
}