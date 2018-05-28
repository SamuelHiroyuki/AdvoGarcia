using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.UC;

namespace AdvoGarcia.Telas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tabControl.SelectedIndex = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnCadAdv_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tabPageCadAdv.Controls.Clear();
            ucAdv uca = new ucAdv();
            tabPageCadAdv.Controls.Add(uca);
            uca.Location = new Point(5, 0);
            uca.Show();
        }
    }
}
