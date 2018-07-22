using AdvoGarcia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.DAO
{
    class ClienteDAO
    {
        private EntidadesContext contexto;

        public ClienteDAO()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void Remover(Cliente cliente)
        {
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
        }

        public void Atualizar()
        {
            contexto.SaveChanges();
        }

        public bool Verificar(string User, string Pass)
        {
            if (contexto.Clientes.FirstOrDefault(c => c.User.Equals(User) && c.Pass.Equals(Pass)) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Cliente Logado(string User, string Pass)
        {
            return contexto.Clientes.FirstOrDefault(c => c.User.Equals(User) && c.Pass.Equals(Pass));
        }

        public bool Confirmar(string user)
        {
            if (contexto.Clientes.FirstOrDefault(c => c.User.Equals(user)) != null)
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
