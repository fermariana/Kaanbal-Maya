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
    public partial class frutas1 : Form
    {
        public frutas1()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            frutas2 frm = new frutas2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_CLick(object sender, EventArgs e)
        {
            frutas frm = new frutas();
            frm.Show();
            this.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("guayaba.wav");
            simpleSound.Play();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("higo.wav");
            simpleSound.Play();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("jicama.wav");
            simpleSound.Play();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("lima.wav");
            simpleSound.Play();
        }
    }
}
