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
    public partial class alfabeto2 : Form
    {
        public alfabeto2()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("honda.wav");
            simpleSound.Play();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("esposa.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("tapa.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("persona.wav");
            simpleSound.Play();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Clicl(object sender, EventArgs e)
        {
            alfabeto3 frm = new  alfabeto3();
            frm.Show();
            this.Visible = false;
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            alfabeto1 frm = new alfabeto1();
            frm.Show();
            this.Visible = false;
        }
    }
}
