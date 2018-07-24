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

        public void Atualizar()
        {
            contexto.SaveChanges();
        }

        public Caso BuscaPorIDCaso(int id)
        {
            return contexto.Casos.FirstOrDefault(c => c.ID == id);
        }

        public Caso BuscaPorID(int id)
        {
            return contexto.Casos.FirstOrDefault(c => c.ClienteID == id);
        }
    }
}
