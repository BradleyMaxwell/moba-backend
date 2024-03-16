using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moba.Backend.Domain.Models;

namespace Moba.Backend.Domain.Interfaces
{
    public interface IHeroService
    {
        public Hero GetHero(Guid heroId);
    }
}