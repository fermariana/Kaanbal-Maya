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
    public partial class frases : Form
    {
        public frases()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a1.wav");
            simpleSound.Play();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a2.wav");
            simpleSound.Play();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a3.wav");
            simpleSound.Play();
        }

        private void pictureBox5_(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a4.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("a5.wav");
            simpleSound.Play();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer("a6.wav");
            simpleSound.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new  menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            frases1 frm = new frases1();
            frm.Show();
            this.Visible = false;
        }
    }
}
