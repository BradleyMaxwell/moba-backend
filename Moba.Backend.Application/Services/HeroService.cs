using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moba.Backend.Domain;
using Moba.Backend.Domain.Models;

namespace Moba.Backend.Application.Services
{
    public class HeroService
    {
        public Hero GetHero(Guid heroId)
        {
            return new Hero();
        }
    }
}