using CruddDapperWebApi.Dto;
using CruddDapperWebApi.Models;
using CruddDapperWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CruddDapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;
        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }

        [HttpGet("{usuarioId}")]
        public async Task<ActionResult<ResponseModel<List<UsuarioListarDto>>>> BuscarUsuarioPorId(int usuarioId)
        {
            var usuario = await _usuarioInterface.BuscarUsuarioPorId(usuarioId);
            

            if(usuario.Status == false)
            {
                return NotFound(usuario);
            }

            return Ok(usuario);
        }

        [HttpGet]
        public async Task<ActionResult<ResponseModel<List<UsuarioListarDto>>>>BuscarUsuarios()
        {
            var usuarios = await _usuarioInterface.BuscarUsuarios();

            if (usuarios.Status == false)
            {
                return NotFound(usuarios);
            }

            return Ok(usuarios);
        }

        [HttpPost]

        public async Task<IActionResult> CriarUsuario(UsuarioCriarDto usuarioCriarDto)
        {
            var usuario = await _usuarioInterface.CriarUsuario(usuarioCriarDto);

            if (usuario.Status == false)
            {
                return Bad(usuario);
            }

            return Ok(usuario);
        }

    }
}
