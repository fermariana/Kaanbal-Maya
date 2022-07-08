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
    public partial class animales : Form
    {
        public animales()
        {
            InitializeComponent();
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            animales1 frm = new animales1();
            frm.Show();
            this.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("perro.wav");
            simpleSound.Play();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("gato.wav");
            simpleSound.Play();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("gallina.wav");
            simpleSound.Play();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("guajolote.wav");
            simpleSound.Play();
        }
    }
}
