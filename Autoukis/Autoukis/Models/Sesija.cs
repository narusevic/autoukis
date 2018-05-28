using System;

namespace Autoukis.Models
{
    public class Sesija
    {
        public int Id { get; set; }
        public DateTime Pradzia { get; set; }
        public DateTime Pabaiga { get; set; }
        public int VarotojoId { get; set; }
    }
}
