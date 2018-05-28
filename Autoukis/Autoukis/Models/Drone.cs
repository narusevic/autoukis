using System;
using System.Collections.Generic;

namespace Autoukis.Models
{
    public class Dronas
    {
        public int Id { get; set; }
        public double BaterijosLygis { get; set; }
        public bool Prieinamumas { get; set; }
        public List<byte[]> Vaizdas { get; set; }
        public TechninePriemone TechninePriemone { get; set; }
    }
}
