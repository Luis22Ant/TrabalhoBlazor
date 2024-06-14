using ApiProjetoEngenharia.Application.Login;
using ApiProjetoEngenharia.Communication.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetoEngenharia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]

        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var useCase = new LoginUseCase();

            var response = await useCase.Execute(request);

            if (response is null)
                return NotFound();

            return Ok(response);
        }
    }
}
