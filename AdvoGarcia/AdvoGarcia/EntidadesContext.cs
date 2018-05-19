using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using AdvoGarcia.Entidades;
using System.Configuration;

namespace AdvoGarcia
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Caso> Casos { get; set; }
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string stringConexao = ConfigurationManager.ConnectionStrings["dbAdvoGarciaConnectionString1"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
