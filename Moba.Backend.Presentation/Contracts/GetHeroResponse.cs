using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moba.Backend.Presentation.Contracts
{
    public record GetHeroResponse
    (
        Guid heroId,
        string name,
        string description,
        int health,
        int damage,
        int defense
    );
}