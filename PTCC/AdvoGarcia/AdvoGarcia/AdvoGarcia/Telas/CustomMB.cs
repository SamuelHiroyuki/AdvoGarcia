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
        public CustomMB(CorFundo bg)
        {
            InitializeComponent();
            switch (bg)
            {
                case CorFundo.Verde:
                    this.BackColor = Color.FromArgb(32, 119, 47);
                    label1.Text = "wsihrufowiaehtiuhretgiserhugtsuehrgushrlfsgjlrtjglsirejgrtdgffff";
                    break;
                case CorFundo.Amarelo:
                    this.BackColor = Color.FromArgb(218, 22, 60);
                    break;
                case CorFundo.Vermelho:
                    this.BackColor = Color.FromArgb(254, 129, 4);
                    break;
            }
        }

        public enum CorFundo {
            Verde, Amarelo, Vermelho
        }
    }
}
