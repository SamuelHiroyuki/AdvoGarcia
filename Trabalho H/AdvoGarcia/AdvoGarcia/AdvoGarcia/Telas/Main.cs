using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.UC;
using AdvoGarcia.Classes;

namespace AdvoGarcia.Telas
{
    public partial class frmMain : Form
    {
        Advogado atuala, adc;
        Cliente atualc, cda;
        int min = 0, seg = 0;

        public frmMain(Advogado aa)
        {
            atuala = aa;
            InitializeComponent();
            tabControl.SelectedIndex = 0;
            lblHome.Text = "Seja bem-vindo " + atuala.Nome.ToString();
            lblTempo.Text = string.Empty;
            lblLastLog.Text = atuala.LastLog.ToString();
            try
            {
                picAdv.Image = Image.FromFile(atuala.Foto);
            }
            catch (Exception)
            { }
            ucChat1.Visible = false;
        }

        public frmMain(Cliente cc)
        {
            atualc = cc;
            InitializeComponent();
            tabControl.SelectedIndex = 0;
            lblHome.Text = "Seja bem-vindo " + atualc.Nome.ToString();
            lblTempo.Text = string.Empty;
            try
            {
                picAdv.Image = Image.FromFile(atualc.Foto);
            }
            catch (Exception)
            { }
            btnCadAdv.Enabled = false;
            btnCadCli.Enabled = false;
            btnQuery.Enabled = false;
            btnCli.Enabled = false;
            label2.Visible = false;
            ucMsg1.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (atuala != null)
            {
                lblHome.Text = "Seja bem-vindo " + atuala.Nome.ToString();
            }
            else
            {
                lblHome.Text = "Seja bem-vindo " + atualc.Nome.ToString();
            }
            tabControl.SelectedIndex = 0;
        }

        private void btnCadAdv_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tabPageCadAdv.Controls.Clear();
            ucAdv uca = new ucAdv();
            MetroFramework.Controls.MetroTile btnVoltar = this.btnVoltar;
            tabPageCadAdv.Controls.Add(btnVoltar);
            tabPageCadAdv.Controls.Add(uca);
            btnVoltar.Location = new Point(5, 0);
            uca.Location = new Point(5, 0);
            uca.Show();
            btnVoltar.Show();

            //ucCustomSaveBtn btn = new ucCustomSaveBtn(ucCustomSaveBtn.TipoBtn.Voltar);
            //tabPageCadAdv.Controls.Add(btn);
            //btn.Location = new Point(304, 19);
            //btn.Show();
            //btn.BringToFront();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tabPageCadAdv.Controls.Clear();
            if (atuala != null)
            {
                ucAdv uca = new ucAdv(atuala);
                MetroFramework.Controls.MetroTile btnVoltar = this.btnVoltar;
                tabPageCadAdv.Controls.Add(btnVoltar);
                tabPageCadAdv.Controls.Add(uca);
                btnVoltar.Location = new Point(5, 0);
                uca.Location = new Point(5, 0);
                uca.Show();
            }
            else
            {
                ucCli ucc = new ucCli(atualc);
                MetroFramework.Controls.MetroTile btnVoltar = this.btnVoltar;
                tabPageCadAdv.Controls.Add(btnVoltar);
                tabPageCadAdv.Controls.Add(ucc);
                btnVoltar.Location = new Point(5, 0);
                ucc.Location = new Point(5, 0);
                ucc.Show();
            }
            btnVoltar.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tabPageCadAdv.Controls.Clear();
            ucCli ucc = new ucCli();
            MetroFramework.Controls.MetroTile btnVoltar = this.btnVoltar;
            tabPageCadAdv.Controls.Add(btnVoltar);
            tabPageCadAdv.Controls.Add(ucc);
            btnVoltar.Location = new Point(5, 0);
            ucc.Location = new Point(5, 0);
            ucc.Show();
            btnVoltar.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnCaso_Click(object sender, EventArgs e)
        {

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

        private void tmrTempLog_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                seg = 0;
                min++;
            }

            if (min < 10)
            {
                lblTempo.Location = new Point(56, 28);
            }
            else
            {
                lblTempo.Location = new Point(43, 28);
            }

            if (seg < 10)
            {
                lblTempo.Text = min.ToString() + " : " + "0" + seg.ToString();
            }
            else
            {
                lblTempo.Text = min.ToString() +  " : " + seg.ToString();
            }
        }
    }
}
