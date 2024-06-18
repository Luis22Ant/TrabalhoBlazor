using ApiProjetoEngenharia.Application.Grupo.Register;
using ApiProjetoEngenharia.Application.Grupo.GetAll;
using ApiProjetoEngenharia.Communication.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProjetoEngenharia.Application.Grupo.GetGrupo;
using ApiProjetoEngenharia.Application.Grupo.Update;
using ApiProjetoEngenharia.Application.Grupo.Delete;

namespace ApiProjetoEngenharia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Register(GrupoRequest request)
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
        [Route("{grupoId}")]
        public async Task<IActionResult> GetAll([FromRoute] int grupoId)
        {
            var useCase = new GetGrupoUseCase();

            var response = await useCase.Execute(grupoId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpPut]
        [Route("{grupoId}")]

        public async Task<IActionResult> Update(GrupoRequest request, [FromRoute] int grupoId)
        {
            var useCase = new UpdateUseCase();

            var response = await useCase.Execute(request, grupoId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpDelete]
        [Route("{grupoId}")]
        public async Task<IActionResult> Delete([FromRoute] int grupoId)
        {
            var useCase = new DeleteUseCase();

            var response = await useCase.Execute(grupoId);

            if (!response)
                return NotFound();

            return Ok(response);
        }
    }
}
