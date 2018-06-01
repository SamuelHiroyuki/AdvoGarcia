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
            veriCli();
        }

        public frmMain(Cliente cc)
        {
            atualc = cc;
            InitializeComponent();
            tabControl.SelectedIndex = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tabPageCadAdv.Controls.Clear();
            ucAdv uca = new ucAdv(atuala);
            MetroFramework.Controls.MetroTile btnVoltar = this.btnVoltar;
            tabPageCadAdv.Controls.Add(btnVoltar);
            tabPageCadAdv.Controls.Add(uca);
            btnVoltar.Location = new Point(5, 0);
            uca.Location = new Point(5, 0);
            uca.Show();
            btnVoltar.Show();
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
                lblTempo.Location = new Point(56, 15);
            }
            else
            {
                lblTempo.Location = new Point(43, 15);
            }

            if (seg < 9)
            {
                lblTempo.Text = min.ToString() + " : " + "0" + seg.ToString();
            }
            else
            {
                lblTempo.Text = min.ToString() +  " : " + seg.ToString();
            }
        }

        public void veriCli() {
            if (atuala.Id_Caso > 0)
            {
                cda = new Cliente();
                cda.PegaIdCaso(atuala.Id_Caso);
                lblIdCli.Text = cda.Id.ToString();
                lblNomeCli.Text = cda.Nome.ToString();
                lblTelCli.Text = cda.Telefone.ToString();
                try
                {
                    picCli.Image = Image.FromFile(cda.Foto);
                }
                catch (Exception){}
            }
        }
    }
}
