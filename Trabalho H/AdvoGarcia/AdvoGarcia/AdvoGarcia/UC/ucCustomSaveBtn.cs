using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvoGarcia.UC
{
    public partial class ucCustomSaveBtn : UserControl
    {
        TipoBtn tb;
        public ucCustomSaveBtn(TipoBtn t)
        {
            tb = t;
            InitializeComponent();
            //403; 0
            //473; 0
            this.BackgroundImage = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\1.png");

            switch (tb)
            {
                case TipoBtn.Save:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\s1.png");
                    break;
                case TipoBtn.Reset:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\r1.png");
                    break;
                case TipoBtn.Clear:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\e1.png");
                    break;
                case TipoBtn.Voltar:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\a1.png");
                    break;
            }

        }

        public enum TipoBtn {
            Save, Reset, Clear, Voltar
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\c2.png");

            switch (tb)
            {
                case TipoBtn.Save:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\s2.png");
                    break;
                case TipoBtn.Reset:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\r2.png");
                    break;
                case TipoBtn.Clear:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\e2.png");
                    break;
                case TipoBtn.Voltar:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\a2.png");
                    break;
            }
        }

        private void pic_MouseHover(object sender, EventArgs e)
        {
            p_MouseHover(sender, e);
        }

        private void p_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\c1.png");

            switch (tb)
            {
                case TipoBtn.Save:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\s1.png");
                    break;
                case TipoBtn.Reset:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\r1.png");
                    break;
                case TipoBtn.Clear:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\e1.png");
                    break;
                case TipoBtn.Voltar:
                    pic.Image = Image.FromFile(@"C: \Users\samhi\Documents\GitHub\PTCC\Trabalho H\Resources\Icon\CustomBtn\a1.png");
                    break;
            }
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            p_MouseLeave(sender, e);
        }
    }
}
