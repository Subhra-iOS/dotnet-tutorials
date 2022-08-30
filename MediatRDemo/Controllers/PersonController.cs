using MediatRDemo.ModelDto;
using Microsoft.AspNetCore.Mvc;
using MediatRDemo.Quries;

namespace MediatRDemo.Controllers
{
    [ApiController]
    [Route("list")]
    public class PersonController: ControllerBase
    {
        private readonly MediatR.IMediator _mediatR;
        public PersonController(MediatR.IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        // GET /list
        [HttpGet]
        public async Task<IEnumerable<PersonDto>> GetPersonList()
        {
            var peopleRequest = await _mediatR.Send(new GetPersonListQuery());
            return peopleRequest;
        }
    }
}