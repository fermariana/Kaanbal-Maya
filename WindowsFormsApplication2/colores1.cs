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

namespace WindowsFormsApplication2
{
    public partial class colores1 : Form
    {
        public colores1()
        {
            InitializeComponent();
        }

        

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
          SoundPlayer simpleSound = new SoundPlayer("azul.wav");
            simpleSound.Play();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("anaranjado.wav");
            simpleSound.Play();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("cafe.wav");
            simpleSound.Play();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("Amarillo.wav");
            simpleSound.Play();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("morado.wav");
            simpleSound.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            colores frm = new colores();
            frm.Show();
        }
    }
}
