using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.DAO;

namespace AdvoGarcia.Telas
{
    public partial class frmLogin : Form
    {
        int u, p;
        AdvogadoDAO adao = new AdvogadoDAO();
        ClienteDAO cdao = new ClienteDAO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Usuário"))
            {
                txtUser.Text = "";
                u = 0;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Senha"))
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                p = 0;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "Usuário";
                u = 1;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.Text = "Senha";
                txtPass.UseSystemPasswordChar = false;
                p = 1;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
            if (e.KeyChar == 11)
            {
                txtUser_Leave(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
            if (e.KeyChar == 11)
            {
                txtPass_Leave(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnClose;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Equals(string.Empty) || txtPass.Text.Trim().Equals(string.Empty) || p == 1 || u == 1)
            {
                this.ActiveControl = null;
                lineShape1.BorderColor = Color.FromArgb(217, 19, 39);
                lineShape1.SelectionColor = Color.FromArgb(217, 19, 39);
                lineShape2.BorderColor = Color.FromArgb(217, 19, 39);
                lineShape2.SelectionColor = Color.FromArgb(217, 19, 39);
                CustomMB.Show("Preencha todos os campos!", CustomMB.CorFundo.Amarelo);
            }
            else
            {
                if (adao.Verificar(txtUser.Text, txtPass.Text) == true)
                {
                    this.Hide();
                    frmMain main = new frmMain(adao.Logado(txtUser.Text, txtPass.Text));
                    main.ShowDialog();
                }
                else
                {
                    if (cdao.Verificar(txtUser.Text, txtPass.Text) == true)
                    {
                        this.Hide();
                        frmMain main = new frmMain(cdao.Logado(txtUser.Text, txtPass.Text));
                        main.ShowDialog();
                    }
                    else
                    {
                        this.ActiveControl = null;
                        lineShape1.BorderColor = Color.FromArgb(217, 19, 39);
                        lineShape1.SelectionColor = Color.FromArgb(217, 19, 39);
                        lineShape2.BorderColor = Color.FromArgb(217, 19, 39);
                        lineShape2.SelectionColor = Color.FromArgb(217, 19, 39);
                        CustomMB.Show("Os dados estão incorretos!", CustomMB.CorFundo.Vermelho);
                    }
                }
            }
        }
    }
}
