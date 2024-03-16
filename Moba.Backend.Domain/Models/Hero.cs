using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moba.Backend.Domain.Models
{
    public class Hero
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public int Health { get; set; }

        public int Attack { get; set; }
        
        public int Defense { get; set; }
    }
}