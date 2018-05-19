using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdvoGarcia.Classes
{
    public class Caso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public int TempGasto { get; set; }

        public void Cadastrar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbCaso(Status_Caso, Descricao_Caso, TempoGasto)" +
                "values (@status, @desc, @temp)";

            cmd.Parameters.Add("@desc", SqlDbType.VarChar, 256).Value = this.Descricao;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 10).Value = "Andamento";
            cmd.Parameters.Add("@temp", SqlDbType.Int).Value = 0;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public Caso PegaID(string s)
        {
            Caso caso = new Caso();
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select ID_Caso, Descricao_Caso from tbCaso";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Descricao_Caso"].ToString().Equals(s))
                {
                    caso.Id = (int)dr["ID_Caso"];
                }
            }
            cn.Close();
            return caso;
        }
    }
}
