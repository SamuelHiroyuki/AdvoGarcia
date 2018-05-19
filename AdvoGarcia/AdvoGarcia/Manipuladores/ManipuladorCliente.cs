using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvoGarcia.Entidades;

namespace AdvoGarcia.Manipuladores
{
    public class ManipuladorCliente
    {
        private EntidadesContext contexto;

        public ManipuladorCliente()
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

        public bool Verificar(string User, string Pass)
        {
            Cliente cli = contexto.Clientes.FirstOrDefault(c => c.User.Equals(User) && c.Pass.Equals(Pass));
            if (cli == null)
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
