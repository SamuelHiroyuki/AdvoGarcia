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
        public string Ani { get; set; }
        public string LastLog { get; set; }

        public void Cadastrar() {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbAdvogado(Nome_Adv, End_Adv, Email_Adv, Foto_Adv, User_Adv, Pass_Adv, CPF_Adv, Tel_Adv, QtdCasos, PrecoHR, Ani_Adv, Area)" +
                "values (@nome, @end, @email, @foto, @user, @pass, @cpf, @tel, @qtd, @prec, @ani, @area)";

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
            cmd.Parameters.Add("@ani", SqlDbType.VarChar, 250).Value = this.Ani;
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
                this.Ani = dr[11].ToString();
                this.Area = dr[12].ToString();
                this.LastLog = dr[13].ToString();
                cn.Close();
                return true;
            }
            cn.Close();
            return false;
        }

        public bool Confirmar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select ID_Advogado from tbAdvogado where User_Adv = @user COLLATE SQL_Latin1_General_CP1_CS_AS";

            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cn.Close();
                return true;
            }
            cn.Close();
            return false;
        }

        public void Atualizar() {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "update tbAdvogado set Nome_Adv = @nome, End_Adv = @end, Email_Adv = @email, Foto_Adv = @foto, " +
                "User_Adv = @user, Pass_Adv = @pass, CPF_Adv = @cpf, Tel_Adv = @tel, QtdCasos = @qtd, PrecoHR = @prec, Ani_Adv = @ani, Area = @area " +
                "where ID_Advogado = @id;";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
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
            cmd.Parameters.Add("@ani", SqlDbType.VarChar, 250).Value = this.Ani;
            cmd.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = this.Area;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public Advogado PegaPorID(int s)
        {
            Advogado adv = new Advogado();
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select * from tbCaso";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToInt32(dr["ID_Advogado"]) == s)
                {
                    adv.Id = (int)dr[0];
                    adv.Nome = dr[1].ToString();
                    adv.Endereco = dr[2].ToString();
                    adv.Email = dr[3].ToString();
                    adv.Telefone = dr[8].ToString();
                    adv.CPF = dr[7].ToString();
                    adv.Foto = dr[4].ToString();
                    adv.QtdCasos = (int)dr[9];
                    adv.PrecoHR = (int)dr[10];
                    adv.Ani = dr[11].ToString();
                    adv.Area = dr[12].ToString();
                    adv.LastLog = dr[13].ToString();
                    cn.Close();
                    return adv;
                }
            }
            cn.Close();
            return null;
        }
    }
}
