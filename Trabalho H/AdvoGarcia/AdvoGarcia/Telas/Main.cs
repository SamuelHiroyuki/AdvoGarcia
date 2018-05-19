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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tabControl.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadA_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 1;
                }
            }
            else
            {
                tabControl.SelectedIndex = 0;
            }
        }

        private void btnAltA_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 1;
                }
            }
            else
            {
                tabControl.SelectedIndex = 2;
            }
        }

        private void btnCadC_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 4)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 1;
                }
            }
            else
            {
                tabControl.SelectedIndex = 4;
            }
        }

        private void btnAltC_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 3)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 1;
                }
            }
            else
            {
                tabControl.SelectedIndex = 3;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 5)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 1;
                }
            }
            else
            {
                tabControl.SelectedIndex = 5;
            }
        }
    }
}
