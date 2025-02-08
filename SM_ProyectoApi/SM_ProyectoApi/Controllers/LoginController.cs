using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SM_ProyectoApi.Models;

namespace SM_ProyectoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("RegistrarCuenta")]
        public IActionResult RegistrarCuenta(UsuarioModel model)
        {
            using (var context = new SqlConnection(_configuration.GetSection("ConnectionStrings:BDConnection").Value))
            {
                var result = context.Execute("RegistrarCuenta", 
                    new { model.Identificacion, model.Contrasenna, model.Nombre, model.Correo });
            }

            return Ok();
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public IActionResult IniciarSesion(UsuarioModel model)
        {
            using (var context = new SqlConnection(_configuration.GetSection("ConnectionStrings:BDConnection").Value))
            {
                var result = context.QueryFirstOrDefault<UsuarioModel>("IniciarSesion",
                    new { model.Identificacion, model.Contrasenna });

                return Ok(result);
            }           
        }

    }
}
