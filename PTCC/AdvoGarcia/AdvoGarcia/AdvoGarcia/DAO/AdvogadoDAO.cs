using AdvoGarcia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.DAO
{
    class AdvogadoDAO
    {
        private EntidadesContext contexto;

        public AdvogadoDAO()
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

        public void Atualizar()
        {
            contexto.SaveChanges();
        }

        public Advogado BuscaPorID(int id) {
            return contexto.Advogados.FirstOrDefault(a => a.ID == id);
        }

        public bool Verificar(string User, string Pass)
        {
            if (contexto.Advogados.FirstOrDefault(a => a.User.Equals(User) && a.Pass.Equals(Pass)) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Advogado Logado(string User, string Pass) {
            return contexto.Advogados.FirstOrDefault(a => a.User.Equals(User) && a.Pass.Equals(Pass));
        }

        public bool Confirmar(string user) {
            if (contexto.Advogados.FirstOrDefault(a => a.User.Equals(user)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
