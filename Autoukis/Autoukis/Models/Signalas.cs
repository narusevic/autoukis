using System;

namespace Autoukis.Models
{
    public class Signalas
    {
        public int Id { get; set; }
        public TechninePriemone TechninePriemone { get; set; }
        public int LaikoLimitas { get; set; }
        public DateTime Laikas { get; set; }
    }
}
