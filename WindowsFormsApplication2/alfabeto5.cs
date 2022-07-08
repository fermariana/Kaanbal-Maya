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
    public partial class alfabeto5 : Form
    {
        public alfabeto5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("pluma.wav");
            simpleSound.Play();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("padre.wav");
            simpleSound.Play();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("pavo.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHiver(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("nido.wav");
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
            alfabeto frm = new alfabeto();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            alfabeto4 frm = new alfabeto4();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("pluma.wav");
            simpleSound.Play();
        }
    }
}
