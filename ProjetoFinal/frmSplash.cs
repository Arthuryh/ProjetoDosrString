using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Desaparece();
        }

        public void Desaparece()
        {
            this.timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 1;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            SoundPlayer sndPlayer = new SoundPlayer(Properties.Settings.Default.localMidia + "intro.wav");
            sndPlayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if (ativo)
            {
                this.Opacity -= 0.01D;
            }
            if (this.Opacity == 0)
            {
                ativo = false;
                timer1.Enabled = false;
                frmLogin janela = new frmLogin();
                janela.Show();
                this.Hide();
            }
        }
    }
}