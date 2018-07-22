using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Entidades;

namespace AdvoGarcia.Telas
{
    public partial class frmPedirSenha : Form
    {
        public frmPedirSenha()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Equals(string.Empty) || txtPass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Campos vazio!","Atenção");
            }
            else
            {
                this.Close();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
