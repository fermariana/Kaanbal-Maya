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
    public partial class alfabeto3 : Form
    {
        public alfabeto3()
        {
            InitializeComponent();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("atole.wav");
            simpleSound.Play();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("yerno.wav");
            simpleSound.Play();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("cola.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("perro2.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("espejo.wav");
            simpleSound.Play();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("huevo.wav");
            simpleSound.Play();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("tos.wav");
            simpleSound.Play();
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("nuera.wav");
            simpleSound.Play();
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("sol.wav");
            simpleSound.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            alfabeto4 frm = new alfabeto4();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            alfabeto2 frm = new alfabeto2();
            frm.Show();
            this.Visible = false;
        }
    }
}
