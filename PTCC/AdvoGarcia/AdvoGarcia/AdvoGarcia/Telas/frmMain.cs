using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvoGarcia.DAO;
using AdvoGarcia.Entidades;
using AdvoGarcia.UC;

namespace AdvoGarcia.Telas
{
    public partial class frmMain : Form
    {

        //585; 430 min 
        //1060; 630 max
        //0; 65; 82
        int min = 0, seg = 0;
        Advogado al;
        Cliente cl;
        AdvogadoDAO adao = new AdvogadoDAO();
        ClienteDAO cdao = new ClienteDAO();

        public frmMain()
        {
            InitializeComponent();
        }


        public frmMain(Advogado a)
        {
            al = a;
            InitializeComponent();
            lblNome.Text = al.Nome;
            lblEmail.Text = al.Email;
            lblCargo.Text = "Advogado - " + al.Especializacao;
            try
            {
                picPerfil.BackgroundImage = Image.FromFile(al.Foto);
            }
            catch (Exception)
            { }
            picNot.Visible = false;
        }

        public frmMain(Cliente c)
        {
            cl = c;
            InitializeComponent();
            lblNome.Text = cl.Nome;
            lblEmail.Text = cl.Email;
            lblCargo.Text = "Cliente - nº" + cl.ID;
            try
            {
                picPerfil.BackgroundImage = Image.FromFile(cl.Foto);
            }
            catch (Exception)
            { }
            picNot.Visible = false;
            btnConsulta.Enabled = false;
            btnCadA.Enabled = false;
            btnCadC.Enabled = false;
            btnCli.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadA_Click(object sender, EventArgs e)
        {
            LimparLat();
            lat1.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            ucAdv uc = new ucAdv();
            pnlMostrar.Controls.Add(uc);
            pnlMostrar.BringToFront();
            uc.Show();
        }

        private void btnCadC_Click(object sender, EventArgs e)
        {
            LimparLat();
            lat2.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            ucCli uc = new ucCli();
            pnlMostrar.Controls.Add(uc);
            pnlMostrar.BringToFront();
            uc.Show();
        }

        private void btnAltD_Click(object sender, EventArgs e)
        {
            picNot.Visible = true;
            LimparLat();
            lat3.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            if (al != null) {
                ucAltA uc = new ucAltA(al.ID);
                pnlMostrar.Controls.Add(uc);
                pnlMostrar.BringToFront();
                uc.Show();
            }
            else
            {
                ucAltC uc = new ucAltC(cl.ID);
                pnlMostrar.Controls.Add(uc);
                pnlMostrar.BringToFront();
                uc.Show();
            }
        }

        private void tmrTempLog_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                seg = 0;
                min++;
            }

            if (min <= 0)
            {
                if (seg < 10)
                {
                    lblTempo.Text = "0" + min.ToString() + ":" + "0" + seg.ToString();
                }
                else
                {
                    lblTempo.Text = "0" + min.ToString() + ":" + seg.ToString();
                }
            }
            else
            {
                if (seg < 10)
                {
                    lblTempo.Text = min.ToString() + ":" + "0" + seg.ToString();
                }
                else
                {
                    lblTempo.Text = min.ToString() + ":" + seg.ToString();
                }
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            al = null;
            cl = null;
            this.Hide();
            login.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            LimparLat();
            lat0.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            ucConsulta uc = new ucConsulta();
            pnlMostrar.Controls.Add(uc);
            pnlMostrar.BringToFront();
            uc.Show();
            picNot.Visible = true;
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            LimparLat();
            lat4.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            ucConCli uc = new ucConCli(al);
            pnlMostrar.Controls.Add(uc);
            pnlMostrar.BringToFront();
            uc.Show();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (al != null)
            {
                al = adao.BuscaPorID(al.ID);
                lblNome.Text = al.Nome;
                lblEmail.Text = al.Email;
                lblCargo.Text = "Advogado - " + al.Especializacao;
                try
                {
                    picPerfil.BackgroundImage = Image.FromFile(al.Foto);
                }
                catch (Exception)
                { }
            }
            else
            {
                cl = cdao.BuscaPorID(cl.ID);
                lblNome.Text = cl.Nome;
                lblEmail.Text = cl.Email;
                lblCargo.Text = "Cliente - nº" + cl.ID;
                try
                {
                    picPerfil.BackgroundImage = Image.FromFile(cl.Foto);
                }
                catch (Exception)
                { }
            }
            picNot.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LimparLat();
            pnlMostrar.Controls.Clear();
            pictureBox2.BringToFront();
        }

        private void btnCaso_Click(object sender, EventArgs e)
        {
            LimparLat();
            lat5.BackColor = Color.FromArgb(0, 65, 82);
            pnlMostrar.Controls.Clear();
            if (al != null)
            {
                ucConCaso uc = new ucConCaso(al);
                pnlMostrar.Controls.Add(uc);
                pnlMostrar.BringToFront();
                uc.Show();
            }
            else
            {
                ucConCaso uc = new ucConCaso(cl);
                pnlMostrar.Controls.Add(uc);
                pnlMostrar.BringToFront();
                uc.Show();
            }
        }

        public void LimparLat() {
            lat0.BackColor = Color.FromArgb(28, 177, 137);
            lat1.BackColor = Color.FromArgb(28, 177, 137);
            lat2.BackColor = Color.FromArgb(28, 177, 137);
            lat3.BackColor = Color.FromArgb(28, 177, 137);
            lat4.BackColor = Color.FromArgb(28, 177, 137);
            lat5.BackColor = Color.FromArgb(28, 177, 137);
        }
    }
}
