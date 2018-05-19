using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Manipuladores;
using AdvoGarcia.Entidades;

namespace AdvoGarcia
{
    public partial class frmCadastroAdv : Form
    {
        ManipuladorAdvogado ma = new ManipuladorAdvogado();

        public frmCadastroAdv()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEnd.Text.Equals("") || txtEmail.Text.Equals("") || txtEsp.Text.Equals("") || txtUser.Text.Equals("") || txtPass.Text.Equals("") || nudHr.Value == 0 || txtCPF.Text.Equals("") || txtTel.Text.Equals(""))
            {
                MessageBox.Show("erro", "Erro");
            } else
            {
                Advogado a = new Advogado(){
                    Nome = txtNome.Text,
                    CPF = Convert.ToInt32(txtCPF.Text),
                    Endedreco = txtEnd.Text,
                    Telefone = Convert.ToInt32(txtTel.Text),
                    Email = txtEmail.Text,
                    PrecoPorHR = Convert.ToInt32(nudHr.Value),
                    QtdCasos = Convert.ToInt32(nudQTDcaso.Value),
                    Especializacao = txtEsp.Text,
                    User = txtUser.Text,
                    Pass = txtPass.Text
                };
                ma.Salvar(a);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
