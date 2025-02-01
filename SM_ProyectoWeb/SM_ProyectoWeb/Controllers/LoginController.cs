using Microsoft.AspNetCore.Mvc;

namespace SM_ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult IniciarSesion()
        {
            return View();
        }

        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult RegistrarCuenta()
        {
            return View();
        }

        public IActionResult RecuperarContrasenna()
        {
            return View();
        }
    }
}
