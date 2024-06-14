﻿using ApiProjetoEngenharia.Application.Usuario.GetAll;
using ApiProjetoEngenharia.Application.Usuario.Register;
using ApiProjetoEngenharia.Communication.Request;
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

    }
}