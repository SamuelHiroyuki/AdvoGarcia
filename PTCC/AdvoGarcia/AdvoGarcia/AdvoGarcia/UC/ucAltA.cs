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
using AdvoGarcia.Telas;

namespace AdvoGarcia.UC
{
    public partial class ucAltA : UserControl
    {
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        Advogado a;
        AdvogadoDAO adao = new AdvogadoDAO();

        public ucAltA(int id)
        {
            this.a = adao.BuscaPorID(id);
            InitializeComponent();
            Carregar();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboArea.SelectedIndex == -1 || txtUser.Text.Equals(string.Empty) || txtPass.Text.Equals(string.Empty) || nudPrec.Value == 0))
            {
                a.Nome = txtNome.Text;
                a.Endereco = txtEnd.Text;
                a.CPF = txtCPF.Text;
                a.Telefone = txtTel.Text;
                a.Email = txtEmail.Text;
                a.Nascimento = dateNasci.Text;
                a.Especializacao = cboArea.Text;
                try
                {
                    a.Foto = copyImgToFolder();
                }
                catch (Exception)
                { }
                a.PrecoPorHR = Convert.ToInt32(nudPrec.Value);
                a.QtdCasos = Convert.ToInt32(nudQtdC.Value);
                a.Pass = txtPass.Text;

                if (a.User.Equals(txtUser))
                {
                    a.User = txtUser.Text;
                    if (adao.Confirmar(a.User))
                    {
                        MessageBox.Show("Já existe advogado com esse nome de usuario.", "Atenção");
                    }
                    else
                    {
                        adao.Atualizar();
                        MessageBox.Show("Advogado atualizado", "Sucesso");
                        this.Dispose();
                    }
                }
                else
                {
                    adao.Atualizar();
                    MessageBox.Show("Advogado atualizado", "Sucesso");
                }
            }
            else
            {
                MessageBox.Show("Campos vazios!", "Atenção");
            }
        }

        private void btnReca_Click(object sender, EventArgs e)
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

        public void Carregar() {
            txtNome.Text = a.Nome;
            txtEnd.Text = a.Endereco;
            txtCPF.Text = a.CPF;
            txtTel.Text = a.Telefone;
            txtEmail.Text = a.Email;
            dateNasci.Text = a.Nascimento;
            txtUser.Text = a.User;
            txtPass.Text = a.Pass;
            nudPrec.Value = Convert.ToUInt32(a.PrecoPorHR);
            nudQtdC.Value = Convert.ToUInt32(a.QtdCasos);
            try
            {
                picPerfil.Image = Image.FromFile(a.Foto);
            }
            catch (Exception) { }
            cboArea.SelectedIndex = cboArea.Items.IndexOf(a.Especializacao);
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
