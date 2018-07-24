using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Telas;
using AdvoGarcia.Entidades;
using AdvoGarcia.DAO;

namespace AdvoGarcia.UC
{
    public partial class ucCli : UserControl
    {
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };

        public ucCli()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtNome.Text.Equals(string.Empty) || txtEnd.Text.Equals(string.Empty) || txtCPF.Text.Length != 14 || txtTel.Text.Length != 15 || txtEmail.Text.Equals(string.Empty) || !txtEmail.Text.Contains("@") || cboFormPag.SelectedIndex == -1 || fileName.Equals(string.Empty)))
            {
                ClienteDAO cdao = new ClienteDAO();
                frmPedirSenha frm = new frmPedirSenha();
                frm.ShowDialog();
                Cliente nc = new Cliente()
                {
                    Nome = txtNome.Text,
                    Endereco = txtEnd.Text,
                    CPF = txtCPF.Text,
                    Telefone = txtTel.Text,
                    Email = txtEmail.Text,
                    FormaPagamento = cboFormPag.Text,
                    Foto = copyImgToFolder(),
                    User = frm.txtUser.Text,
                    Pass = frm.txtPass.Text
                };

                if (cdao.Confirmar(nc.User))
                {
                    CustomMB.Show("Já existe um cliente com esse nome de usuario cadastrado!", CustomMB.CorFundo.Vermelho);
                }
                else
                {
                    cdao.Salvar(nc);
                    CustomMB.Show("Cliente cadastrado com sucesso!", CustomMB.CorFundo.Verde);
                    frmPedirCaso pc = new frmPedirCaso();
                    pc.ShowDialog();
                    CasoDAO casodao = new CasoDAO();
                    Caso caso = new Caso(){
                        Status = "Andamento",
                        Descricao = pc.txtCaso.Text,
                        Cliente = nc
                    };
                    casodao.Salvar(caso);
                    btnClear_Click(sender, e);
                    nc = null;
                }
            }
            else
            {
                CustomMB.Show("Alguns campos estão vazios!", CustomMB.CorFundo.Amarelo);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            picPerfil.Image = null;
            cboFormPag.SelectedIndex = -1;
            fileName = string.Empty;
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
