using System;
using System.Collections.Generic;

namespace Autoukis.Models
{
    public class Uzklausa
    {
        public int Id { get; set; }
        public List<TechninePriemone> TechninesPriemones { get; set; }
        public Sesija Siuntejas { get; set; }
    }
}
