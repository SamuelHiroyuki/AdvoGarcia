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

        public ucCli(Cliente cc)
        {
            c = cc;
            InitializeComponent();
            btnCaso.Enabled = false;
            btnClearRe.Text = "Recarregar";
            txtNome.Text = c.Nome.ToString();
            txtEnd.Text = c.Endereco.ToString();
            txtCPF.Text = c.CPF.ToString();
            txtTel.Text = c.Telefone.ToString();
            txtEmail.Text = c.Email.ToString();
            txtUser.Text = c.User.ToString();
            txtPass.Text = c.Pass.ToString();
            try
            {
                picAdv.Image = Image.FromFile(c.Foto);
            }
            catch (Exception) { }
            lblImgPath.Text = c.Foto.ToString();
            cboFormPag.SelectedIndex = cboFormPag.Items.IndexOf(c.FormaPaga);
        }

        private void btnCaso_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescCaso.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            chkCaso.Checked = false;
            tabControl.SelectedIndex = 0;
            txtDescCaso.Text = string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDescCaso.Text.Equals(string.Empty))
            {
                MessageBox.Show("O campo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                chkCaso.Checked = true;
                tabControl.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboFormPag.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty)))
                {
                    if (chkCaso.Checked == true)
                    {
                        Cliente nc = new Cliente();
                        nc.Nome = txtNome.Text;
                        nc.Endereco = txtEnd.Text;
                        nc.CPF = txtCPF.Text;
                        nc.Telefone = txtTel.Text;
                        nc.Email = txtEmail.Text;
                        nc.User = txtUser.Text;
                        nc.Pass = txtPass.Text;
                        nc.FormaPaga = cboFormPag.Text;
                        nc.Foto = copyImgToFolder();

                        if (nc.Confirmar())
                        {
                            MessageBox.Show("Já existe cliente com esse nome de usuario.", "Atenção");
                        }
                        else
                        {
                            nc.Cadastrar();
                            Caso caso = new Caso();
                            caso.Descricao = txtDescCaso.Text;
                            caso.Cliente.Id = nc.Id;
                            MessageBox.Show("Cliente cadastrado", "Sucesso");
                            btnClearRe_Click(sender, e);
                            nc = null;
                            caso = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O cliente não cadastrou o Caso", "Atenção");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                }
            }
            else
            {
                if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboFormPag.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty)))
                {
                    c.Nome = txtNome.Text;
                    c.Endereco = txtEnd.Text;
                    c.CPF = txtCPF.Text;
                    c.Telefone = txtTel.Text;
                    c.Email = txtEmail.Text;
                    c.Pass = txtPass.Text;
                    c.FormaPaga = cboFormPag.Text;
                    if (!c.Foto.Equals(lblImgPath.Text))
                    {
                        c.Foto = copyImgToFolder();
                    }

                    if (c.User.Equals(txtUser))
                    {
                        c.User = txtUser.Text;
                        if (c.Confirmar())
                        {
                            MessageBox.Show("Já existe cliente com esse nome de usuario.", "Atenção");
                        }
                        else
                        {
                            c.Atualizar();
                            MessageBox.Show("Cliente atualizado", "Sucesso");
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
            if (c == null)
            {
                txtNome.Text = string.Empty;
                txtEnd.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                picAdv.Image = null;
                cboFormPag.SelectedIndex = -1;
                lblImgPath.Text = string.Empty;
                fileName = string.Empty;
            }
            else
            {
                txtNome.Text = c.Nome.ToString();
                txtEnd.Text = c.Endereco.ToString();
                txtCPF.Text = c.CPF.ToString();
                txtTel.Text = c.Telefone.ToString();
                txtEmail.Text = c.Email.ToString();
                txtUser.Text = c.User.ToString();
                txtPass.Text = c.Pass.ToString();
                try
                {
                    picAdv.Image = Image.FromFile(c.Foto);
                }
                catch (Exception) { }
                lblImgPath.Text = c.Foto.ToString();
                cboFormPag.SelectedIndex = cboFormPag.Items.IndexOf(c.FormaPaga);
            }
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
