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
        int i = 0;
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        public frmMain()
        {
            InitializeComponent();
            tabControl.SelectedIndex = 1;
            cboFormP.Items.Add("Cheque");
            cboFormP.Items.Add("Cartão de Crédito");
            cboFormP.Items.Add("Cartão de Débito");
            cboAltFormP.Items.Add("Cheque");
            cboAltFormP.Items.Add("Cartão de Crédito");
            cboAltFormP.Items.Add("Cartão de Débito");
        }

        //
        //-------------------------------Menu-------------------------------
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        //-------------------------------Cad Adv-------------------------------
        //
        private void btnCadA_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1 && tabControl.SelectedIndex != 0)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 0;
                    limpar();
                }
            }
            else
            {
                tabControl.SelectedIndex = 0;
            }
        }
        private void btnCancelA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                tabControl.SelectedIndex = 1;
                limpar();
            }
        }

        private void btnCOpImA_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picCAdv.BackgroundImage = Image.FromFile(fileName);
            }
        }

        private void btnCClearImA_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picCAdv.BackgroundImage = null;
        }

        private void btnSaveA_Click(object sender, EventArgs e)
        {
            copyImgToFolder();
        }

        //
        //-------------------------------Alt Adv-------------------------------
        //
        private void btnAltA_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1 && tabControl.SelectedIndex != 2)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 2;
                    limpar();
                }
            }
            else
            {
                tabControl.SelectedIndex = 2;
            }
        }
        private void btnACancelA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                tabControl.SelectedIndex = 1;
                limpar();
            }
        }

        private void btnAOpImA_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picAAdv.BackgroundImage = Image.FromFile(fileName);
            }
        }

        private void btnAClearImA_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picAAdv.BackgroundImage = null;
        }

        private void btnASaveA_Click(object sender, EventArgs e)
        {
            copyImgToFolder();
        }

        //
        //-------------------------------Cad Cli-------------------------------
        //
        private void btnCadC_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1 && tabControl.SelectedIndex != 4)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 4;
                    limpar();
                }
            }
            else
            {
                tabControl.SelectedIndex = 4;
            }
        }
        private void btnCCloseC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                tabControl.SelectedIndex = 1;
                limpar();
            }
        }

        private void btnCOpImC_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picCadCli.BackgroundImage = Image.FromFile(fileName);
            }
        }

        private void btnCClearImC_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picCadCli.BackgroundImage = null;
        }

        private void btnCSaveC_Click(object sender, EventArgs e)
        {
            copyImgToFolder();
        }

        //
        //-------------------------------Alt Cli-------------------------------
        //
        private void btnAltC_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1 && tabControl.SelectedIndex != 3)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 3;
                    limpar();
                }
            }
            else
            {
                tabControl.SelectedIndex = 3;
            }
        }
        private void btnACloseC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                tabControl.SelectedIndex = 1;
                limpar();
            }
        }

        private void btnAOpImC_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picAltCli.BackgroundImage = Image.FromFile(fileName);
            }
        }

        private void btnAClearImC_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picAltCli.BackgroundImage = null;
        }

        private void btnASaveC_Click(object sender, EventArgs e)
        {
            copyImgToFolder();
        }

        //
        //-------------------------------Consulta-------------------------------
        //
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1 && tabControl.SelectedIndex != 5)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    tabControl.SelectedIndex = 5;
                }
            }
            else
            {
                tabControl.SelectedIndex = 5;
            }
        }

        //
        //-------------------------------Caso-------------------------------
        //
        private void btnCaso_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;
            i = 1;
        }

        private void btnAltCaso_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;
            i = 2;
        }

        private void btnCasoClose_Click(object sender, EventArgs e)
        {
            txtDescCaso.Text = string.Empty;
            if (i == 1)
            {
                checkCaso.Checked = false;
                i = 0;
                tabControl.SelectedIndex = 4;
            }
            else
            {
                checkAltcaso.Checked = false;
                i = 0;
                tabControl.SelectedIndex = 3;
            }
        }

        private void btnCasoSave_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (txtDescCaso.Text.Equals(string.Empty))
                {
                    MessageBox.Show("O campo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    i = 0;
                    checkCaso.Checked = true;
                    tabControl.SelectedIndex = 4;
                }
            }
            else
            {
                if (txtDescCaso.Text.Equals(string.Empty))
                {
                    MessageBox.Show("O campo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    checkAltcaso.Checked = true;
                    i = 0;
                    tabControl.SelectedIndex = 3;
                }
            }
        }

        //
        //-------------------------------Métodos-------------------------------
        //
        private void copyImgToFolder()
        {
            string nomev = string.Empty;
            int j = 0;

            string targetPath = @"C:\Users\samhi\Desktop\Trabalho H\AdvoGarcia\Fotos";

            string sourceFile = System.IO.Path.Combine(fileName);
            string nom = (j).ToString() + ".jpg";
            string destFile = System.IO.Path.Combine(targetPath, nom);

            do
            {
                if (System.IO.File.Exists(@"C:\Users\samhi\Desktop\Trabalho H\AdvoGarcia\Fotos\" + nom))
                {
                    nomev = (j++).ToString() + ".jpg";
                    destFile = System.IO.Path.Combine(targetPath, nomev);
                }
            } while (System.IO.File.Exists(@"C:\Users\samhi\Desktop\Trabalho H\AdvoGarcia\Fotos\" + nomev));

            System.IO.File.Copy(sourceFile, destFile, true);
        }

        private void limpar()
        {
            //Cadastro Adv
            txtCNomeA.Text = string.Empty;
            txtCEndA.Text = string.Empty;
            txtCTelA.Text = string.Empty;
            txtCEmailA.Text = string.Empty;
            txtCCPFA.Text = string.Empty;
            txtCUserA.Text = string.Empty;
            txtCPassA.Text = string.Empty;
            nudCPrecA.Value = 0;
            nudCQtdCA.Value = 0;
            picCAdv.BackgroundImage = null;
            //Alter Adv
            txtANomeA.Text = string.Empty;
            txtAEndA.Text = string.Empty;
            txtATelA.Text = string.Empty;
            txtAEmailA.Text = string.Empty;
            txtACPFA.Text = string.Empty;
            txtAUserA.Text = string.Empty;
            txtAPassA.Text = string.Empty;
            nudAPrecA.Value = 0;
            nudAQtdA.Value = 0;
            picAAdv.BackgroundImage = null;
            //Cadastro Cli
            txtCNomeC.Text = string.Empty;
            txtCEndC.Text = string.Empty;
            txtCTelC.Text = string.Empty;
            txtCEmailC.Text = string.Empty;
            txtCCPFC.Text = string.Empty;
            txtCUserC.Text = string.Empty;
            txtCPassC.Text = string.Empty;
            cboFormP.Text = null;
            checkCaso.Checked = false;
            picCadCli.BackgroundImage = null;
            //Alter Cli
            txtANomeC.Text = string.Empty;
            txtAEndC.Text = string.Empty;
            txtATelC.Text = string.Empty;
            txtAEmailC.Text = string.Empty;
            txtACPFC.Text = string.Empty;
            txtAUserC.Text = string.Empty;
            txtAPassC.Text = string.Empty;
            cboAltFormP.Text = null;
            checkAltcaso.Checked = false;
            picAltCli.BackgroundImage = null;

            txtDescCaso.Text = string.Empty;
            fileName = string.Empty;
        }
    }
}
