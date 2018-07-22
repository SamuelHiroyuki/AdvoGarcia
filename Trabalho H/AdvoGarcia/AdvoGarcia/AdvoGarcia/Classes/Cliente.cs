﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdvoGarcia.Classes
{
    public class Cliente
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
        public string FormaPaga { get; set; }

        public void Cadastrar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbCliente(Nome_Cli, End_Cli, Email_Cli, Foto_Cli, User_Cli, Pass_Cli, CPF_Cli, Tel_Cli, FormaPaga)" +
                "values (@nome, @end, @email, @foto, @user, @pass, @cpf, @tel, @paga)";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.Nome;
            cmd.Parameters.Add("@end", SqlDbType.VarChar, 50).Value = this.Endereco;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.Email;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar, 100).Value = this.Foto;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = this.Pass;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar, 15).Value = this.Telefone;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 14).Value = this.CPF;
            cmd.Parameters.Add("@paga", SqlDbType.VarChar, 20).Value = this.FormaPaga;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public bool Verificar()
        {
            Caso caso = new Caso();
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select * from tbCliente where User_Cli = @user COLLATE SQL_Latin1_General_CP1_CS_AS and Pass_Cli = " +
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
                this.FormaPaga = dr[9].ToString();
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

            cmd.CommandText = "select ID_Cli from tbCliente where User_Cli = @user COLLATE SQL_Latin1_General_CP1_CS_AS";

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

        public void Atualizar()
        {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "update tbCliente set Nome_Cli = @nome, End_Cli = @end, Email_Cli = @email, Foto_Cli = @foto, User_Cli = @user, Pass_Cli = @pass, " +
                "CPF_Cli = @cpf, Tel_Cli = @tel, FormaPaga = @paga where ID_Cli = @id;";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = this.Nome;
            cmd.Parameters.Add("@end", SqlDbType.VarChar, 50).Value = this.Endereco;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.Email;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar, 100).Value = this.Foto;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = this.User;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = this.Pass;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar, 15).Value = this.Telefone;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 14).Value = this.CPF;
            cmd.Parameters.Add("@paga", SqlDbType.VarChar, 20).Value = this.FormaPaga;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //public void PegaIdCaso(int s)
        //{
        //    SqlConnection cn = Conexao.conectar();
        //    SqlCommand cmd = cn.CreateCommand();
        //    cmd.CommandText = "select * from tbCliente where ID_Caso = @id";
        //    cmd.Parameters.Add("@id", SqlDbType.Int).Value = s;
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        this.Id = (int)dr[0];
        //        this.Nome = dr[1].ToString();
        //        this.Telefone = dr[8].ToString();
        //        this.Foto = dr[4].ToString();
        //    }
        //    cn.Close();
        //}
    }
}
