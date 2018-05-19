using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvoGarcia.Entidades;

namespace AdvoGarcia.Manipuladores
{
    public class ManipuladorAdvogado
    {
        private EntidadesContext contexto;

        public ManipuladorAdvogado()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Advogado advogado)
        {
            contexto.Advogados.Add(advogado);
            contexto.SaveChanges();
        }

        public void Remover(Advogado advogado)
        {
            contexto.Advogados.Remove(advogado);
            contexto.SaveChanges();
        }

        public bool Verificar(string User, string Pass) {
            Advogado adv = contexto.Advogados.FirstOrDefault(a => a.User.Equals(User) && a.Pass.Equals(Pass));
            if (adv == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
