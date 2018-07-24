using AdvoGarcia.DAO;
using AdvoGarcia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvoGarcia.Telas
{
    public partial class frmPedirCaso : Form
    {
        public bool Del { get; set; }
        public bool Alt { get; set; }
        Caso cc;
        int i;
        CasoDAO cdao = new CasoDAO();

        public frmPedirCaso()
        {
            InitializeComponent();
        }

        public frmPedirCaso(Caso c)
        {
            this.cc = c;
            InitializeComponent();
            txtCaso.Text = c.Descricao;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnEnc.Visible = true;
            btnCan.Visible = true;
            txtCaso.Enabled = false;
        }

        public frmPedirCaso(int id, bool b)
        {
            cc = cdao.BuscaPorIDCaso(id);
            InitializeComponent();
            txtCaso.Text = cc.Descricao;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnEnc.Visible = false;
            btnCan.Visible = false;
            txtCaso.Enabled = false;
            btnOk.Visible = true;
        }

        public frmPedirCaso(int id, int b, bool x)
        {
            this.i = b;
            cc = cdao.BuscaPorIDCaso(id);
            InitializeComponent();
            txtCaso.Text = cc.Descricao;
            btnClear.Visible = false;
            btnSave.Visible = true;
            btnEnc.Visible = false;
            btnCan.Visible = true;
            txtCaso.Enabled = true;
            btnOk.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCaso.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (txtCaso.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Campos vazio!", "Atenção");
                }
                else
                {
                    cc.Descricao = txtCaso.Text;
                    cdao.Atualizar();
                    i = 0;
                    Alt = true;
                    this.Close();
                }
            }
            else
            {
                if (txtCaso.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Campos vazio!", "Atenção");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            Del = true;
            this.Close();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                Alt = false;
                this.Close();
            }
            else
            {
                Del = false;
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
