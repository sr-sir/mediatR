using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRCase.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("Login")]
        public async Task Login(NewUser newUser)
        {
            await _mediator.Publish(newUser);
            
        }
    }
}