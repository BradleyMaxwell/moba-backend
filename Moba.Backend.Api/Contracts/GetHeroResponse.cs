using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moba.Backend.Api.Contracts
{
    public record GetHeroResponse(
        Guid heroId,
        string Name,
        string Description,
        int Health,
        int Attack,
        int Defense
    );
}