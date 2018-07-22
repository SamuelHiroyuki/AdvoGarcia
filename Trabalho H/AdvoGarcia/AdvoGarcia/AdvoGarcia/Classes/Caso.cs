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
        public Cliente Cliente { get; set; }
        public Advogado Advogado { get; set; }

        public void Cadastrar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbCaso(Status_Caso, Descricao_Caso, ID_Cli)" +
                "values (@status, @desc, @cli)";

            cmd.Parameters.Add("@desc", SqlDbType.VarChar, 256).Value = this.Descricao;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 10).Value = "Andamento";
            cmd.Parameters.Add("@cli", SqlDbType.Int).Value = this.Cliente.Id;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //public Caso PegaPorID(int s)
        //{
        //    Caso caso = new Caso();
        //    Advogado adv = new Advogado();
        //    SqlConnection cn = Conexao.conectar();
        //    SqlCommand cmd = cn.CreateCommand();
            
        //    cmd.CommandText = "select * from tbCaso";
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        if (Convert.ToInt32(dr["ID_Caso"]) == s)
        //        {
        //            caso.Id = (int)dr["ID_Caso"];
        //            caso.Descricao = dr["Descricao_Caso"].ToString();
        //            caso.Status = dr["Status_Caso"].ToString();
        //            caso.Advogado = adv.PegaPorID((int)dr[3]);
        //        }
        //    }
        //    cn.Close();
        //    return caso;
        //}
    }
}
