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
    public partial class frutas2 : Form
    {
        public frutas2()
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
            fruta3 frm = new fruta3();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_(object sender, EventArgs e)
        {
            frutas1 frm = new frutas1();
            frm.Show();
            this.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("limon.wav");
            simpleSound.Play();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("mamey.wav");
            simpleSound.Play();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer("mango.wav");
            simpleSound.Play();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("manzana.wav");
            simpleSound.Play();
        }
    }
}
