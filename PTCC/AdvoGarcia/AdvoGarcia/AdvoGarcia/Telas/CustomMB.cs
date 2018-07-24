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
    public partial class CustomMB : Form
    {
        public CustomMB(string texto, CorFundo bg)
        {
            InitializeComponent();
            label1.Text = texto;
            switch (bg)
            {
                case CorFundo.Verde:
                    this.BackColor = Color.FromArgb(50, 194, 77);
                    pictureBox1.Image = imageList1.Images[0];
                    break;
                case CorFundo.Amarelo:
                    this.BackColor = Color.FromArgb(254, 129, 4);
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case CorFundo.Vermelho:
                    this.BackColor = Color.Crimson;
                    pictureBox1.Image = imageList1.Images[2];
                    break;
            }
        }

        public enum CorFundo {
            Verde, Amarelo, Vermelho
        }

        public static void Show(string texto, CorFundo bg)
        {
            new AdvoGarcia.Telas.CustomMB(texto, bg).Show();
        }

        private void CustomMB_Load(object sender, EventArgs e)
        {
            this.Top = 700;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 150;

            show.Start();
        }

        int i = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top > 500)
            {
                this.Top -= i;
                i += 5;
            }
            else
            {
                show.Stop();
                timeout.Start();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void closealert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2;
            }
            else
            {
                this.Close();
            }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }
    }
}
