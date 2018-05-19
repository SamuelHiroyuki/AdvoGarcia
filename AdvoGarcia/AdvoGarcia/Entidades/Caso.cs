using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.Entidades
{
    public class Caso
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public int TempoTotal { get; set; }
    }
}
