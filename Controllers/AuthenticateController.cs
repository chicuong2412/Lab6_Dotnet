using Microsoft.AspNetCore.Mvc;

namespace Lab6_LeChiCuong_2131200001.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
