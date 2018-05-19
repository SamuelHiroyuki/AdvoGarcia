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

namespace AdvoGarcia
{
    public partial class frmLogin : Form
    {
        ManipuladorAdvogado ma = new ManipuladorAdvogado();
        ManipuladorCliente mc = new ManipuladorCliente();

        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((ma.Verificar(txtUser.Text, txtPass.Text) == true) || (mc.Verificar(txtUser.Text, txtPass.Text) == true))
            {
                //txtUser.LineIdleColor = Color.FromArgb(0, 112, 204);
                //txtPass.LineIdleColor = Color.FromArgb(0, 112, 204);
                MessageBox.Show("Teste", "Certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //txtUser.LineIdleColor = Color.FromArgb(232, 17, 35);
                //txtUser.LineMouseHoverColor = Color.FromArgb(232, 17, 35);
                //txtUser.LineFocusedColor = Color.FromArgb(232, 17, 35);
                //txtPass.LineIdleColor = Color.FromArgb(232, 17, 35);
                //txtPass.LineMouseHoverColor = Color.FromArgb(232, 17, 35);
                //txtPass.LineFocusedColor = Color.FromArgb(232, 17, 35);
                MessageBox.Show("Teste", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            txtPass.isPassword = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
