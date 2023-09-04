using AutoMapper_API.Handlers.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AutoMapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ApiController
    {
        private readonly ISender _mediator;
        public PersonsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesErrorResponseType(typeof(ErrorOr.ErrorOr))]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPersonByIdQuery(id);
            var result = await _mediator.Send(query);

            return result.Match(resp => StatusCode((int)HttpStatusCode.OK, resp),
                errors => Problem(errors));
        }
    }
}
