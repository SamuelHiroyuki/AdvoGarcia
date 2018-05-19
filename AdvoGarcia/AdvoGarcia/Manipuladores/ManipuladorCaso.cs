using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvoGarcia.Entidades;

namespace AdvoGarcia.Manipuladores
{
    public class ManipuladorCaso
    {
        private EntidadesContext contexto;

        public ManipuladorCaso() {
            contexto = new EntidadesContext();
        }

        public void Salvar(Caso caso) {
            contexto.Casos.Add(caso);
            contexto.SaveChanges();
        }

        public void Remover(Caso caso)
        {
            contexto.Casos.Remove(caso);
            contexto.SaveChanges();
        }
    }
}
