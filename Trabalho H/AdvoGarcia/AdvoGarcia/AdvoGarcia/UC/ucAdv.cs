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
    public partial class ucAdv : UserControl
    {
        int i = 0;
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        Advogado a;

        public ucAdv()
        {
            InitializeComponent();
        }

        public ucAdv(Advogado aa)
        {
            a = aa;
            InitializeComponent();
            btnClearRe.Text = "Recarregar";
            txtNome.Text = a.Nome.ToString();
            txtEnd.Text = a.Endereco.ToString();
            txtCPF.Text = a.CPF.ToString();
            txtTel.Text = a.Telefone.ToString();
            txtEmail.Text = a.Email.ToString();
            dateNasci.Text = a.Ani.ToString();
            txtUser.Text = a.User.ToString();
            txtPass.Text = a.Pass.ToString();
            nudPrec.Value = Convert.ToUInt32(a.PrecoHR);
            nudQtdC.Value = Convert.ToUInt32(a.QtdCasos);
            try
            {
                picAdv.Image = Image.FromFile(a.Foto);
            }
            catch (Exception){}
            cboArea.SelectedIndex = cboArea.FindStringExact(a.Area.ToString());
            lblImgPath.Text = a.Foto.ToString();
            cboArea.SelectedIndex = cboArea.Items.IndexOf(a.Area);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboArea.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty) || nudPrec.Value == 0))
                {
                    Advogado na = new Advogado();
                    na.Nome = txtNome.Text;
                    na.Endereco = txtEnd.Text;
                    na.CPF = txtCPF.Text;
                    na.Telefone = txtTel.Text;
                    na.Email = txtEmail.Text;
                    na.User = txtUser.Text;
                    na.Pass = txtPass.Text;
                    na.Ani = dateNasci.Text;
                    na.Area = cboArea.SelectedText;
                    na.Foto = copyImgToFolder();
                    na.PrecoHR = Convert.ToInt32(nudPrec.Value);
                    na.QtdCasos = Convert.ToInt32(nudQtdC.Value);

                    if (na.Confirmar())
                    {
                        MessageBox.Show("Já existe advogado com esse CPF.", "Atenção");
                    }
                    else
                    {
                        na.Cadastrar();
                        MessageBox.Show("Advogado cadastrado", "Sucesso");
                        btnClearRe_Click(sender, e);
                        na = null;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                }
            }
            else
            {

            }
        }

        private void btnClearRe_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                txtNome.Text = string.Empty;
                txtEnd.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtEmail.Text = string.Empty;
                dateNasci.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                nudPrec.Value = 0;
                nudQtdC.Value = 0;
                picAdv.Image = null;
                cboArea.SelectedIndex = -1;
                lblImgPath.Text = string.Empty;
                fileName = string.Empty;
            }
        }
    }
}
