using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SM_ProyectoApi.Models;

namespace SM_ProyectoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("RegistrarCuenta")]
        public IActionResult RegistrarCuenta(UsuarioModel model)
        {
            //llamar a la base de datos

            return Ok();
        }

    }
}
