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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            //deixa o fundo transparente
            this.TransparencyKey = (BackColor);
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            tmrClose.Enabled = false;
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
