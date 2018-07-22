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
using AdvoGarcia.Telas;
using AdvoGarcia.DAO;

namespace AdvoGarcia.UC
{
    public partial class ucAdv : UserControl
    {
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        
        public ucAdv()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dateNasci.Text = string.Empty;
            nudPrec.Value = 0;
            nudQtdC.Value = 0;
            picPerfil.Image = null;
            cboArea.SelectedIndex = -1;
            fileName = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboArea.SelectedIndex == -1 || nudPrec.Value == 0 || fileName.Equals(string.Empty)))
            {
                AdvogadoDAO adao = new AdvogadoDAO();
                frmPedirSenha frm = new frmPedirSenha();
                frm.ShowDialog();
                Advogado na = new Advogado()
                {
                    Nome = txtNome.Text,
                    Endereco = txtEnd.Text,
                    CPF = txtCPF.Text,
                    Telefone = txtTel.Text,
                    Email = txtEmail.Text,
                    Nascimento = dateNasci.Text,
                    Especializacao = cboArea.Text,
                    Foto = copyImgToFolder(),
                    PrecoPorHR = Convert.ToInt32(nudPrec.Value),
                    QtdCasos = Convert.ToInt32(nudQtdC.Value),
                    User = frm.txtUser.Text,
                    Pass = frm.txtPass.Text
                };

                if (adao.Confirmar(na.User))
                {
                    MessageBox.Show("Já existe advogado com esse nome de usuario.", "Atenção");
                }
                else
                {
                    adao.Salvar(na);
                    MessageBox.Show("Advogado cadastrado", "Sucesso");
                    btnClear_Click(sender, e);
                    na = null;
                }
            }
            else
            {
                MessageBox.Show("Campos vazios!", "Atenção");
            }
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                picPerfil.Image = Image.FromFile(fileName);
            }
        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            picPerfil.Image = null;
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
