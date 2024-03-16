using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moba.Backend.Presentation.Contracts;

namespace Moba.Backend.Presentation
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : ControllerBase
    {
        [HttpGet("{heroId:guid}")]
        public IActionResult GetHero(Guid heroId)
        {
            GetHeroResponse response = new GetHeroResponse
            (
                heroId,
                "Lucian",
                "Everybody dies.",
                500,
                80,
                30
            );

            return Ok(response);
        }
    }
}