using Microsoft.AspNetCore.Mvc;
using SM_ProyectoWeb.Models;

namespace SM_ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly IConfiguration _configuration;
        public LoginController(IHttpClientFactory httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        #region RegistrarCuenta

        [HttpGet]
        public IActionResult RegistrarCuenta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarCuenta(UsuarioModel model)
        {
            using (var api = _httpClient.CreateClient())
            {
                var url = _configuration.GetSection("Variables:urlApi").Value + "Login/RegistrarCuenta";
                var result = api.PostAsJsonAsync(url, model).Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("IniciarSesion", "Login");
                }
            }

            return View();
        }

        #endregion

        #region IniciarSesion

        [HttpGet]
        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(UsuarioModel model)
        {
            using (var api = _httpClient.CreateClient())
            {
                var url = _configuration.GetSection("Variables:urlApi").Value + "Login/IniciarSesion";
                var result = api.PostAsJsonAsync(url, model).Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Principal", "Login");
                }
            }

            return View();
        }

        #endregion

        [HttpGet]
        public IActionResult Principal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RecuperarContrasenna()
        {
            return View();
        }

    }
}
