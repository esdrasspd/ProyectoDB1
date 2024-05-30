using Microsoft.AspNetCore.Mvc;
using ProyectoDB1.Models;
namespace ProyectoDB1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Registrar()
        {
            return View();
        }
    }
}
