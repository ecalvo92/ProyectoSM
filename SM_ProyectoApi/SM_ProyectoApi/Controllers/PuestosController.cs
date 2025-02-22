using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SM_ProyectoApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PuestosController : ControllerBase
    {
        [HttpGet]
        [Route("ConsultarPuestos")]
        public IActionResult ConsultarPuestos()
        {
            return Ok();
        }
    }
}
