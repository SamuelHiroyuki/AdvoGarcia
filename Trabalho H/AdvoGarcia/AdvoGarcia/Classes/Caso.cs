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
        public string Anotacao { get; set; }
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
            cmd.CommandText = "select * from tbCaso";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Descricao_Caso"].ToString().Equals(s))
                {
                    caso.Id = (int)dr["ID_Caso"];
                    caso.Descricao = dr["Descricao_Caso"].ToString();
                    caso.Status = dr["Status_Caso"].ToString();
                    caso.TempGasto = (int)dr["TempoGasto"];
                }
            }
            cn.Close();
            return caso;
        }

        public Caso PegaID(int s)
        {
            Caso caso = new Caso();
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * from tbCaso";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["ID_Caso"]) == s)
                {
                    caso.Id = (int)dr["ID_Caso"];
                    caso.Descricao = dr["Descricao_Caso"].ToString();
                    caso.Status = dr["Status_Caso"].ToString();
                    caso.Anotacao = dr["Anot"].ToString();
                    caso.TempGasto = (int)dr["TempoGasto"];
                }
            }
            cn.Close();
            return caso;
        }

        public void Anota()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "update tbCaso set Anot = @anot where ID_Caso = @id";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
            cmd.Parameters.Add("@anot", SqlDbType.VarChar, 256).Value = this.Anotacao;

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
