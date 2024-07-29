using Application.Features.Mediator.Commands.FooterAddressCommands;
using Application.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediaator)
        {
            _mediator = mediaator;
        }


        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values =await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt adres bilgisi eklendi");
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
             await _mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Alt adres bilgisi silindi");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateFooterAdress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Alt adres bilgisi güncellendi");
        }
             
             

    }
}
