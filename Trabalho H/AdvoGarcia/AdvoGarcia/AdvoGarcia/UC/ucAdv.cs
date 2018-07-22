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
                    na.Area = cboArea.Text;
                    na.Foto = copyImgToFolder();
                    na.PrecoHR = Convert.ToInt32(nudPrec.Value);
                    na.QtdCasos = Convert.ToInt32(nudQtdC.Value);

                    if (na.Confirmar())
                    {
                        MessageBox.Show("Já existe advogado com esse nome de usuario.", "Atenção");
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
                if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboArea.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty) || nudPrec.Value == 0))
                {
                    a.Nome = txtNome.Text;
                    a.Endereco = txtEnd.Text;
                    a.CPF = txtCPF.Text;
                    a.Telefone = txtTel.Text;
                    a.Email = txtEmail.Text;
                    a.Pass = txtPass.Text;
                    a.Ani = dateNasci.Text;
                    a.Area = cboArea.Text;
                    if (!a.Foto.Equals(lblImgPath.Text))
                    {
                        a.Foto = copyImgToFolder();
                    }
                    a.PrecoHR = Convert.ToInt32(nudPrec.Value);
                    a.QtdCasos = Convert.ToInt32(nudQtdC.Value);
                    
                    if (a.User.Equals(txtUser))
                    {
                        a.User = txtUser.Text;
                        if (a.Confirmar())
                        {
                            MessageBox.Show("Já existe advogado com esse nome de usuario.", "Atenção");
                        }
                        else
                        {
                            a.Atualizar();
                            MessageBox.Show("Advogado atualizado", "Sucesso");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                }
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
            else
            {
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
                catch (Exception) { }
                lblImgPath.Text = a.Foto.ToString();
                cboArea.SelectedIndex = cboArea.Items.IndexOf(a.Area);
            }
        }

        private string copyImgToFolder()
        {
            string nomev = string.Empty;
            int j = 0;

            string targetPath = @"C:\Users\samhi\Documents\GitHub\PTCC\Trabalho H\AdvoGarcia\Fotos";

            string sourceFile = System.IO.Path.Combine(fileName);
            string nom = (j).ToString() + ".jpg";
            string destFile = System.IO.Path.Combine(targetPath, nom);

            do
            {
                if (System.IO.File.Exists(@"C:\Users\samhi\Documents\GitHub\PTCC\Trabalho H\AdvoGarcia\Fotos\" + nom))
                {
                    nomev = (j++).ToString() + ".jpg";
                    destFile = System.IO.Path.Combine(targetPath, nomev);
                }
            } while (System.IO.File.Exists(@"C:\Users\samhi\Documents\GitHub\PTCC\Trabalho H\AdvoGarcia\Fotos\" + nomev));

            System.IO.File.Copy(sourceFile, destFile, true);
            if (nomev.Equals(string.Empty))
            {
                return (@"C:\Users\samhi\Documents\GitHub\PTCC\Trabalho H\AdvoGarcia\Fotos\" + nom);
            }
            else
            {
                return (@"C:\Users\samhi\Documents\GitHub\PTCC\Trabalho H\AdvoGarcia\Fotos\" + nomev);
            }
        }
    }
}
