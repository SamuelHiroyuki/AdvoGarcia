using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Entidades;
using AdvoGarcia.Manipuladores;

namespace AdvoGarcia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ManipuladorAdvogado manipulador = new ManipuladorAdvogado();
            //Advogado adv = new Advogado()
            //{
            //    Nome = "Malu",
            //    User = "Maluzinha",
            //    Pass = "123"
            //};
            //manipulador.Salvar(adv);

            //ManipuladorCliente manipulador = new ManipuladorCliente();
            //Cliente cli = new Cliente()
            //{
            //    Nome = "Teste",
            //    User = "Teste",
            //    Pass = "123"
            //};
            //manipulador.Salvar(cli);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCadastroAdv());
        }
    }
}
