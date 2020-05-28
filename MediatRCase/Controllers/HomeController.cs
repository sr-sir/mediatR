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
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPut("Register")]
        public async Task<string> Register(NewUser newUser)
        {
            string str = await _mediator.Send(newUser);
            return str;
        }


        [HttpGet("Register1")]
        public string Register1()
        {

            return "OK";
        }
    }
}