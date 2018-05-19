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
        public Caso Id_Caso { get; set; }

        public void Cadastrar() {
            SqlConnection cn = Conexao.conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "insert into tbAdvogado(Nome_Adv, End_Adv, Email_Adv, Foto_Adv, User_Adv, Pass_Adv, CPF_Adv, Tel_Adv, QtdCasos, PrecoHR)" +
                "values (@nome, @end, @email, @foto, @user, @pass, @cpf, @tel, @qtd, @prec)";

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

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
