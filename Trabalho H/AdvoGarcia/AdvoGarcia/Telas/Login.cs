using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Classes;

namespace AdvoGarcia.Telas
{
    public partial class frmLogin : Form
    {
        Advogado a;
        Cliente c;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            a = new Advogado() { User = txtUser.Text, Pass = txtPass.Text };
            c = new Cliente() { User = txtUser.Text, Pass = txtPass.Text };
            
            if (a.Verificar())
            {
                MessageBox.Show(a.Nome, "Adv");
                this.Hide();
                frmMain main = new frmMain(a);
                main.ShowDialog();
            }
            else
            {
                if (c.Verificar())
                {
                    MessageBox.Show(c.Nome + c.Caso.Id.ToString(), "Cli");
                    this.Hide();
                    frmMain main = new frmMain(c);
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LIXO", "EEEEEEEE");
                }
            }
        }

        //Eventos para ativar o btn com a tecla enter
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
        }

        //Evento para deixar a senha oculta
        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            txtPass.isPassword = true;
        }
    }
}
