using Application.Features.Mediator.Commands.TagCloudCommands;
using Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> TagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);

        }


        [HttpGet("{id}")]

        public async Task<IActionResult> GetSocialMedi(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(values);
        }


        [HttpPost]


        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket bulutu bilgisi eklendi");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket bulutu bilgisi güncellendi");
        }


        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await _mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("Etiket bulutu bilgisi silindi");

        }
    }
}
