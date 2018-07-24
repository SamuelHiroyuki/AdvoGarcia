using AdvoGarcia.UC;
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
    public partial class frmAlt : Form
    {
        public frmAlt(bool t, int id)
        {
            InitializeComponent();
            if (t)
            {
                ucAltA uc = new ucAltA(id);
                panel2.Controls.Add(uc);
                uc.Show();
            }
            else
            {
                ucAltC uc = new ucAltC(id);
                panel2.Controls.Add(uc);
                uc.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
