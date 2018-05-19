using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvoGarcia
{
    class Conexao
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=DESKTOP-OM3PMDT\SQLEXPRESS;Initial Catalog=dbAdvoGarcia;Integrated Security=True";
            cn.Open();
            return (cn);
        }
    }
}
