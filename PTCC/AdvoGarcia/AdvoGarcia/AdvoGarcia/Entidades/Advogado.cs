using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.Entidades
{
    public class Advogado
    {
        [System.ComponentModel.DisplayName("Código do Advogado")]
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Nome")]
        public string Nome { get; set; }
        [System.ComponentModel.DisplayName("CPF")]
        public string CPF { get; set; }
        [System.ComponentModel.DisplayName("Endereço")]
        public string Endereco { get; set; }
        [System.ComponentModel.DisplayName("Telefone")]
        public string Telefone { get; set; }
        [System.ComponentModel.DisplayName("E-mail")]
        public string Email { get; set; }
        [System.ComponentModel.DisplayName("Preço por hora")]
        public int PrecoPorHR { get; set; }
        [System.ComponentModel.DisplayName("Casos Resolvidos")]
        public int QtdCasos { get; set; }
        [System.ComponentModel.DisplayName("Especialização")]
        public string Especializacao { get; set; }
        [System.ComponentModel.DisplayName("Última entrada")]
        public DateTime LastLog { get; set; }
        [System.ComponentModel.DisplayName("Data de nascimento")]
        public string Nascimento { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string User { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Pass { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Foto { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual IList<Caso> Casos { get; set; }
    }
}
