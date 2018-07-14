using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Classes;

namespace AdvoGarcia.UC
{
    public partial class ucCli : UserControl
    {
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        Cliente c;

        public ucCli()
        {
            InitializeComponent();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            txtDescCaso.Text = string.Empty;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            chkCaso.Checked = false;
            tabControl.SelectedIndex = 0;
            txtDescCaso.Text = string.Empty;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (txtDescCaso.Text.Equals(string.Empty))
            {
                MessageBox.Show("O campo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                chkCaso.Checked = true;
                tabControl.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //    if (c == null)
            //    {
            //        if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboFormPag.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty)))
            //        {
            //            //Advogado na = new Advogado();
            //            //na.Nome = txtNome.Text;
            //            //na.Endereco = txtEnd.Text;
            //            //na.CPF = txtCPF.Text;
            //            //na.Telefone = txtTel.Text;
            //            //na.Email = txtEmail.Text;
            //            //na.User = txtUser.Text;
            //            //na.Pass = txtPass.Text;
            //            //na.Area = cboFormPag.SelectedText;
            //            //na.Foto = copyImgToFolder();

            //            if (na.Confirmar())
            //            {
            //                MessageBox.Show("Já existe advogado com esse CPF.", "Atenção");
            //            }
            //            else
            //            {
            //                na.Cadastrar();
            //                MessageBox.Show("Advogado cadastrado", "Sucesso");
            //                btnClearRe_Click(sender, e);
            //                na = null;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Preencha todos os campos!", "Atenção");
            //        }
            //    }
            //    else
            //    {

            //    }
        }

        private void btnClearRe_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picAdv.Image = Image.FromFile(fileName);
                lblImgPath.Text = fileName;
            }
        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picAdv.Image = null;
            lblImgPath.Text = string.Empty;
        }

        private string copyImgToFolder()
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
            if (nomev.Equals(string.Empty))
            {
                return (@"C: \Users\samhi\Desktop\Trabalho H\AdvoGarcia\Fotos\" + nom);
            }
            else
            {
                return (@"C: \Users\samhi\Desktop\Trabalho H\AdvoGarcia\Fotos\" + nomev);
            }
        }
    }
}
