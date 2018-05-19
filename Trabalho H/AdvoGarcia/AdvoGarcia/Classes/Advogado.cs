using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdvoGarcia.Classes
{
    public class Advogado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Foto { get; set; }
        public int QtdCasos { get; set; }
        public int PrecoHR { get; set; }
        public string Area { get; set; }
        public int Id_Caso { get; set; }

        public void Cadastrar() {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbAdvogado(Nome_Adv, End_Adv, Email_Adv, Foto_Adv, User_Adv, Pass_Adv, CPF_Adv, Tel_Adv, QtdCasos, PrecoHR, Area)" +
                "values (@nome, @end, @email, @foto, @user, @pass, @cpf, @tel, @qtd, @prec, @area)";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.Nome;
            cmd.Parameters.Add("@end", SqlDbType.VarChar, 50).Value = this.Endereco;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.Email;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar, 100).Value = this.Foto;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = this.Pass;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar, 15).Value = this.Telefone;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 14).Value = this.CPF;
            cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = this.QtdCasos;
            cmd.Parameters.Add("@prec", SqlDbType.Int).Value = this.PrecoHR;
            cmd.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = this.Area;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public bool Verificar() {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select * from tbAdvogado where User_Adv = @user COLLATE SQL_Latin1_General_CP1_CS_AS and Pass_Adv = " +
                "@pass COLLATE SQL_Latin1_General_CP1_CS_AS ";

            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = this.Pass;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.Id = (int)dr[0];
                this.Nome = dr[1].ToString();
                this.Endereco = dr[2].ToString();
                this.Email = dr[3].ToString();
                this.Telefone = dr[8].ToString();
                this.CPF = dr[7].ToString();
                this.Foto = dr[4].ToString();
                this.QtdCasos = (int)dr[9];
                this.PrecoHR = (int)dr[10];
                this.Area = dr[11].ToString();
                try{ this.Id_Caso = (int)dr["Id_Caso"]; }
                catch (Exception){}
                return true;
            }
            cn.Close();
            return false;
        }

        public bool Confirmar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select ID_Advogado from tbAdvogado where User_Adv = @user COLLATE SQL_Latin1_General_CP1_CS_AS or CPF_Adv = @cpf";

            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 50).Value = this.CPF;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return true;
            }
            cn.Close();
            return false;
        }
    }
}
