using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvoGarcia.Classes
{
    class Mensagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Status { get; set; }
        public Cliente Cliente { get; set; }
        public Advogado Advogado { get; set; }

        public void Cadastrar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbMensagem(Status_Msg, Texto_Msg, ID_Cli, ID_Advogado"
                +"values (@status, @text, @cli, @adv)";

            cmd.Parameters.Add("@text", SqlDbType.NVarChar).Value = this.Texto;
            cmd.Parameters.Add("@status", SqlDbType.Bit).Value = 0;
            cmd.Parameters.Add("@cli", SqlDbType.Int).Value = this.Cliente.Id;
            cmd.Parameters.Add("@adv", SqlDbType.Int).Value = this.Advogado.Id;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

    }
}
