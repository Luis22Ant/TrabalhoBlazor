using ApiProjetoEngenharia.Application.Usuario.Delete;
using ApiProjetoEngenharia.Application.Usuario.GetAll;
using ApiProjetoEngenharia.Application.Usuario.GetUser;
using ApiProjetoEngenharia.Application.Usuario.Register;
using ApiProjetoEngenharia.Application.Usuario.Update;
using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoEngenharia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]

        public async Task<IActionResult> Register([FromBody] UsuarioRequest request)
        {
            var useCase = new RegisterUseCase();

            var response = await useCase.Execute(request);

            if (response is null)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var useCase = new GetAllUseCase();

            var response = await useCase.Execute();

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpGet]
        [Route("{usuarioId}")]
        public async Task<IActionResult> GetUser([FromRoute] int usuarioId)
        {
            var useCase = new GetUserCase();

            var response = await useCase.Execute(usuarioId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpDelete]
        [Route("{usuarioId}")]

        public async Task<IActionResult> Delete([FromRoute] int usuarioId)
        {
            var useCase = new DeleteUseCase();

            var response = await useCase.Execute(usuarioId);

            if(!response)
                return NotFound();

            return Ok(response);
        }

        [HttpPut]
        [Route("{idUsuario}")]

        public async Task<IActionResult> Update([FromRoute] int idUsuario,Usuario user)
        {
            var useCase = new UpdateUseCase();

            var response = await useCase.Execute(idUsuario,user);

            if (response is null)
                return NotFound();

            return Ok(response);
        }


    }
}
