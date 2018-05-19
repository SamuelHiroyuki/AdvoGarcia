using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Endedreco { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string FormaPagamento { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public Caso IDCaso { get; set; }
    }
}
