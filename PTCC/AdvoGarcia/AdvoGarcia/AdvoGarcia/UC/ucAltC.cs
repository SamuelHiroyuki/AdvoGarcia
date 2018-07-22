using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Entidades;
using AdvoGarcia.DAO;

namespace AdvoGarcia.UC
{
    public partial class ucAltC : UserControl
    {
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        Cliente c;
        ClienteDAO cdao = new ClienteDAO();

        public ucAltC(Cliente c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboFormPag.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty)))
            {
                c.Nome = txtNome.Text;
                c.Endereco = txtEnd.Text;
                c.CPF = txtCPF.Text;
                c.Telefone = txtTel.Text;
                c.Email = txtEmail.Text;
                c.FormaPagamento = cboFormPag.Text;
                try
                {
                    c.Foto = copyImgToFolder();
                }
                catch (Exception)
                { }
                c.Pass = txtPass.Text;

                if (c.User.Equals(txtUser))
                {
                    c.User = txtUser.Text;
                    if (cdao.Confirmar(c.User))
                    {
                        MessageBox.Show("Já existe advogado com esse nome de usuario.", "Atenção");
                    }
                    else
                    {
                        cdao.Atualizar();
                        MessageBox.Show("Advogado atualizado", "Sucesso");
                    }
                }
                else
                {
                    cdao.Atualizar();
                    MessageBox.Show("Advogado atualizado", "Sucesso");
                }
            }
            else
            {
                MessageBox.Show("Campos vazios!", "Atenção");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picPerfil.Image = null;
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picPerfil.Image = Image.FromFile(fileName);
            }
        }

        public void Carregar()
        {
            txtNome.Text = c.Nome;
            txtEnd.Text = c.Endereco;
            txtCPF.Text = c.CPF;
            txtTel.Text = c.Telefone;
            txtEmail.Text = c.Email;
            txtUser.Text = c.User;
            txtPass.Text = c.Pass;
            try
            {
                picPerfil.Image = Image.FromFile(c.Foto);
            }
            catch (Exception) { }
            cboFormPag.SelectedIndex = cboFormPag.Items.IndexOf(c.FormaPagamento);
        }

        private string copyImgToFolder()
        {
            string nomev = string.Empty;
            int j = 0;

            string targetPath = @"C:\Users\samhi\Desktop\PTCC\AdvoGarcia\Fotos";

            string sourceFile = System.IO.Path.Combine(fileName);
            string nom = (j).ToString() + ".jpg";
            string destFile = System.IO.Path.Combine(targetPath, nom);

            do
            {
                if (System.IO.File.Exists(@"C:\Users\samhi\Desktop\PTCC\AdvoGarcia\Fotos\" + nom))
                {
                    nomev = (j++).ToString() + ".jpg";
                    destFile = System.IO.Path.Combine(targetPath, nomev);
                }
            } while (System.IO.File.Exists(@"C:\Users\samhi\Desktop\PTCC\AdvoGarcia\Fotos\" + nomev));

            System.IO.File.Copy(sourceFile, destFile, true);
            if (nomev.Equals(string.Empty))
            {
                return (@"C:\Users\samhi\Desktop\PTCC\AdvoGarcia\Fotos\" + nom);
            }
            else
            {
                return (@"C:\Users\samhi\Desktop\PTCC\AdvoGarcia\Fotos\" + nomev);
            }
        }
    }
}
