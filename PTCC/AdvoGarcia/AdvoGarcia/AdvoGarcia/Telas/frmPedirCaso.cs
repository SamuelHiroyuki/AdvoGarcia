using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvoGarcia.Telas
{
    public partial class frmPedirCaso : Form
    {
        public frmPedirCaso()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCaso.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCaso.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Campos vazio!", "Atenção");
            }
            else
            {
                this.Close();
            }
        }
    }
}
