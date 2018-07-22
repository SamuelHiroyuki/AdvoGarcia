using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.Entidades
{
    public class Caso
    {
        [System.ComponentModel.DisplayName("Código do Caso")]
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Status")]
        public string Status { get; set; }
        [System.ComponentModel.DisplayName("Descrição")]
        public string Descricao { get; set; }
        [System.ComponentModel.DisplayName("Código do Cliente")]
        public int ClienteID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual Cliente Cliente { get; set; }
        [System.ComponentModel.DisplayName("Código do Advogado")]
        public int? AdvogadoID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual Advogado Advogado { get; set; }

    }
}
