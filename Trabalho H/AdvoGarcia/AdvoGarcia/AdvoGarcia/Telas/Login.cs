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
            txtUser.LineIdleColor = Color.FromArgb(70, 80, 90);
            txtUser.LineFocusedColor = Color.FromArgb(70, 80, 90);
            txtUser.LineMouseHoverColor = Color.FromArgb(70, 80, 90);
            txtPass.LineIdleColor = Color.FromArgb(70, 80, 90);
            txtPass.LineFocusedColor = Color.FromArgb(70, 80, 90);
            txtPass.LineMouseHoverColor = Color.FromArgb(70, 80, 90);
        }

        //Fecha a aplicação
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botão de logar
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Equals(string.Empty) || txtPass.Text.Trim().Equals(string.Empty))
            {
                this.ActiveControl = null;
                txtUser.LineIdleColor = Color.FromArgb(217, 19, 39);
                txtUser.LineFocusedColor = Color.FromArgb(217, 19, 39);
                txtUser.LineMouseHoverColor = Color.FromArgb(217, 19, 39);
                txtPass.LineIdleColor = Color.FromArgb(217, 19, 39);
                txtPass.LineFocusedColor = Color.FromArgb(217, 19, 39);
                txtPass.LineMouseHoverColor = Color.FromArgb(217, 19, 39);
                MessageBox.Show("Preencha todos os campos!", "Atenção");
            }
            else
            {
                a = new Advogado() { User = txtUser.Text.Trim(), Pass = txtPass.Text.Trim() };
                c = new Cliente() { User = txtUser.Text.Trim(), Pass = txtPass.Text.Trim() };

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

        //Eventos para tirar o foco de tudo
        private void pnlLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}