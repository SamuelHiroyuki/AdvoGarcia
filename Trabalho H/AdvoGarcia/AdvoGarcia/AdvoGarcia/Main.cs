using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.Classes;

namespace AdvoGarcia.Telas
{
    public partial class antigoMain : Form
    {
        //-------------------------------//-------------------------------//-------------------------------//-------------------------------
        int i = 0;
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
        Cliente atualc, clidoadv;
        Advogado atuala, advdocli;
        Caso casoadv;
        //-------------------------------//-------------------------------//-------------------------------//-------------------------------

        public antigoMain(Advogado aa)
        {
            atuala = aa;
            //InitializeComponent();
            tabControl.SelectedIndex = 1;
            attadv();
            cboFormP.Items.Add("Cheque");
            cboFormP.Items.Add("Cartão de Crédito");
            cboFormP.Items.Add("Cartão de Débito");
            cboAltFormP.Items.Add("Cheque");
            cboAltFormP.Items.Add("Cartão de Crédito");
            cboAltFormP.Items.Add("Cartão de Débito");
            btnAltC.Enabled = false;
        }

        public antigoMain(Cliente cc)
        {
            atualc = cc;
            //InitializeComponent();
            try { picCli.BackgroundImage = Image.FromFile(atualc.Foto); }
            catch (Exception) { picCli.BackColor = Color.Black; }
            tabControl.SelectedIndex = 8;
            cboFormP.Items.Add("Cheque");
            cboFormP.Items.Add("Cartão de Crédito");
            cboFormP.Items.Add("Cartão de Débito");
            cboAltFormP.Items.Add("Cheque");
            cboAltFormP.Items.Add("Cartão de Crédito");
            cboAltFormP.Items.Add("Cartão de Débito");
            btnCadA.Enabled = false;
            btnAltA.Enabled = false;
            btnCadC.Enabled = false;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            atuala = null;
            atualc = null;
            this.Hide();
            login.ShowDialog();
        }

        //
        //-------------------------------Home-------------------------------
        //
        private void btnMain_Click(object sender, EventArgs e)
        {
            if (atuala != null)
            {
                if (tabControl.SelectedIndex != 1)
                {
                    if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        tabControl.SelectedIndex = 1;
                        limpar();
                    }
                }
            }
            else
            {
                if (tabControl.SelectedIndex !=8)
                {
                    if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        tabControl.SelectedIndex = 8;
                        limpar();
                    }
                }
            }
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
            if (!(txtCNomeA.Text.Equals(string.Empty) || txtCEndA.Text.Equals(string.Empty) || txtCTelA.Text.Equals(string.Empty) || 
                (txtCEmailA.Text.Equals(string.Empty) || !txtCEmailA.Text.Contains("@")) || txtCCPFA.Text.Equals(string.Empty) || txtCUserA.Text.Equals(string.Empty) || 
                txtCPassA.Text.Equals(string.Empty) || nudCPrecA.Value == 0 || 
                (rdbCDC.Checked == false && rdbCDT.Checked == false && rdbCMed.Checked == false) || fileName.Equals(null)))
            {
                Advogado a = new Advogado();
                a.Nome = txtCNomeA.Text;
                a.Endereco = txtCEndA.Text;
                a.Telefone = txtCTelA.Text;
                a.Email = txtCEmailA.Text;
                a.CPF = txtCCPFA.Text;
                a.User = txtCUserA.Text;
                a.Pass = txtCPassA.Text;
                a.PrecoHR = Convert.ToInt32(nudCPrecA.Value);
                a.QtdCasos = Convert.ToInt32(nudCQtdCA.Value);
                a.Foto = copyImgToFolder();

                if (rdbCDC.Checked){ a.Area = "Direito Civil"; } else{
                    if (rdbCDT.Checked){ a.Area = "Direito Trabalhista"; }
                        else{ a.Area = "Mediação"; } }

                if (a.Confirmar())
                {
                    MessageBox.Show("Já existe no contexto.", "Atenção");
                }
                else
                {
                    a.Cadastrar();
                    MessageBox.Show("Advogado cadastrado", "Sucesso");
                    limpar();
                    a = null;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção");
            }
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
                    atadv();
                }
            }
            else
            {
                tabControl.SelectedIndex = 2;
                atadv();
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
            if (!(txtANomeA.Text.Equals(string.Empty) || txtAEndA.Text.Equals(string.Empty) || txtATelA.Text.Equals(string.Empty) ||
                (txtAEmailA.Text.Equals(string.Empty) || !txtAEmailA.Text.Contains("@")) || txtACPFA.Text.Equals(string.Empty) || 
                txtAUserA.Text.Equals(string.Empty) || txtAPassA.Text.Equals(string.Empty) || nudAPrecA.Value == 0 ||
                (rdbADC.Checked == false && rdbADT.Checked == false && rdbAMed.Checked == false) || picAAdv.BackgroundImage == null))
            {
                atuala.Nome = txtANomeA.Text;
                atuala.Endereco = txtAEndA.Text;
                atuala.Telefone = txtATelA.Text;
                atuala.Email = txtAEmailA.Text;
                atuala.CPF = txtACPFA.Text;
                atuala.User = txtAUserA.Text;
                atuala.Pass = txtAPassA.Text;
                atuala.PrecoHR = Convert.ToInt32(nudAPrecA.Value);
                atuala.QtdCasos = Convert.ToInt32(nudAQtdA.Value);
                if (rdbADC.Checked) { atuala.Area = "Direito Civil"; }
                else
                {
                    if (rdbADT.Checked) { atuala.Area = "Direito Trabalhista"; }
                    else { atuala.Area = "Mediação"; }
                }
                try { atuala.Foto = copyImgToFolder(); }
                catch (Exception) { }
                atuala.Atualizar();
                MessageBox.Show("Advogado alterado", "Sucesso");
                attadv();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção");
            }
        }

        private void btnAReA_Click(object sender, EventArgs e)
        {
            atadv();
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
            if (checkCaso.Checked == false)
            {
                MessageBox.Show("Preencha o Caso", "Atenção");
            }
            else
            {
                Caso caso = new Caso();
                caso.Descricao = txtDescCaso.Text;
                caso.Cadastrar();
                Cliente c = new Cliente();
                c.Nome = txtCNomeC.Text;
                c.Endereco = txtCEndC.Text;
                c.Telefone = txtCTelC.Text;
                c.Email = txtCEmailC.Text;
                c.CPF = txtCCPFC.Text;
                c.User = txtCUserC.Text;
                c.Pass = txtCPassC.Text;
                c.FormaPaga = cboFormP.Text;
                c.Cadastrar();
                MessageBox.Show("Cliente cadastrado", "Sucesso");
                limpar();
                caso = null;
                c = null;
            }
        }

        //
        //-------------------------------Alt Cli-------------------------------
        //
        private void btnAltC_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 8 && tabControl.SelectedIndex != 3)
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

        private void btnReCli_Click(object sender, EventArgs e)
        {

        }

        //
        //-------------------------------Consulta-------------------------------
        //
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (atuala != null)
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
            else
            {
                if (tabControl.SelectedIndex != 8 && tabControl.SelectedIndex != 5)
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
            rdbCDC.Checked = false;
            rdbCDT.Checked = false;
            rdbCMed.Checked = false;
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

        public void atadv() {
            txtANomeA.Text = atuala.Nome;
            txtAEndA.Text = atuala.Endereco;
            txtATelA.Text = atuala.Telefone;
            txtACPFA.Text = atuala.CPF;
            txtAEmailA.Text = atuala.Email;
            txtAUserA.Text = atuala.User;
            txtAPassA.Text = atuala.Pass;
            nudAPrecA.Value = atuala.PrecoHR;
            nudAQtdA.Value = atuala.QtdCasos;
            if (atuala.Area.Equals("Direito Civil")) { rdbADC.Checked = true; }
            else
            {
                if (atuala.Area.Equals("Direito Trabalhista")) { rdbADT.Checked = true; }
                else { rdbAMed.Checked = true; }
            }
            try { picAAdv.BackgroundImage = Image.FromFile(atuala.Foto); }
            catch (Exception) { picAAdv.BackColor = Color.Black; }
        }

        public void attadv() {
            try { picPerf.BackgroundImage = Image.FromFile(atuala.Foto); }
            catch (Exception) { picPerf.BackColor = Color.Black; }

            lblNome.Text = atuala.Nome;
            lblIDAdv.Text = atuala.Id.ToString();
            lblCasoResol.Text = atuala.QtdCasos.ToString();

            //if (atuala.Id_Caso != 0) { btnCasoAdv.Text = "Encerrar Caso"; }
            //else { btnCasoAdv.Text = "Selecionar Caso"; }

            //try
            //{
            //    casoadv = new Caso();
            //    casoadv = casoadv.PegaID(atuala.Id_Caso);
            //    txtCasoAdv.Text = casoadv.Descricao.ToString();
            //    casoadv.Anotacao = txtAnot.Text;
            //    casoadv.Anota();
            //    clidoadv = new Cliente();
            //    clidoadv.PegaIdCaso(casoadv.Id);
            //    lblIDCli.Text = clidoadv.Id.ToString();
            //    lblNomeCli.Text = clidoadv.Nome;
            //    lblEndCli.Text = clidoadv.Endereco;
            //    lblEmailCli.Text = clidoadv.Email;
            //    lblTelCli.Text = clidoadv.Telefone;
            //}
            //catch (Exception) { }

            //try { picCliadv.BackgroundImage = Image.FromFile(clidoadv.Foto); }
            //catch (Exception) { picCliadv.BackColor = Color.Black; }
        }

        private void btnCasoAdv_Click(object sender, EventArgs e)
        {
            //if (atuala.Id_Caso != 0)
            //{
            //    EncerrarCaso();
            //}
            //else
            //{
            //    SelecionarCaso();
            //}
        }

        //
        //-------------------------------Eventos do Cadastro Adv-------------------------------
        //
        private void txtCCPFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limita o TextBox a aceitar apenas números
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCTelA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limita o TextBox a aceitar apenas números
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCNomeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para limitar o TextBox a aceitar apenas caracteres não numéricos
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public void SelecionarCaso() { }

        public void EncerrarCaso() {
            atuala.QtdCasos++;
        }
    }
}
