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
    public partial class frases1 : Form
    {
        public frases1()
        {
            InitializeComponent();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a7.wav");
            simpleSound.Play();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a8.wav");
            simpleSound.Play();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a9.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a10.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a11.wav");
            simpleSound.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            frases frm = new frases ();
            frm.Show();
            this.Visible = false;
        }
    }
}
