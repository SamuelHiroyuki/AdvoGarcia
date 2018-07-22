using AdvoGarcia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.DAO
{
    class CasoDAO
    {
        private EntidadesContext contexto;

        public CasoDAO()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Caso c)
        {
            contexto.Casos.Add(c);
            contexto.SaveChanges();
        }
    }
}
