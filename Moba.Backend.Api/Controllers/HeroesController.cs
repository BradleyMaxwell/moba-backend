using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moba.Backend.Api.Contracts;

namespace Moba.Backend.Api.Controllers
{
    [ApiController]
    [Route("hero")]
    public class HeroesController : ControllerBase
    {
        [HttpGet("{heroId:guid}")]
        public IActionResult GetHero(Guid heroId)
        {
            GetHeroResponse response = new GetHeroResponse
            (
                heroId,
                "Lucian",
                "Gun slinger looking to save or avenge his wife.",
                500,
                80,
                30
            );

            return Ok(response);
        }
    }
}