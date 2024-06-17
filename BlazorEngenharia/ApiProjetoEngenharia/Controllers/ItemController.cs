using ApiProjetoEngenharia.Application.Item.GetAll;
using ApiProjetoEngenharia.Application.Item.GetItem;
using ApiProjetoEngenharia.Application.Item.Register;
using ApiProjetoEngenharia.Application.Item.Delete;
using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProjetoEngenharia.Application.Item.Update;

namespace ApiProjetoEngenharia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var useCase = new GetAllUseCase();

            var response = await useCase.Execute();

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(ItemRequest request)
        {
            var useCase = new RegisterUseCase();

            var response = await useCase.Execute(request);

            if (!response)
                return BadRequest(response);

            return Ok(response);
        }


        [HttpGet]
        [Route("{itemId}")]

        public async Task<IActionResult> GetItem([FromRoute] int itemId)
        {
            var useCase = new GetItemUseCase();

            var response = await useCase.Execute(itemId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpDelete]
        [Route("{itemId}")]

        public async Task<IActionResult> Delete([FromRoute] int itemId)
        {
            var useCase = new DeleteUseCase();

            var response = await useCase.Execute(itemId);

            if (!response)
                return NotFound();

            return Ok(response);
        }


        [HttpPut]
        [Route("{itemId}")]

        public async Task<IActionResult> Update([FromRoute] int itemId, ItemRequest request)
        {
            var useCase = new UpdateUseCase();

            var response = await useCase.Execute(itemId,request);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

    }
}
