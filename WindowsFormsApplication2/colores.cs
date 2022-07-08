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
    public partial class colores : Form
    {
        public colores()
        {
            InitializeComponent();
        }

     

        private void pictureBox5_Click(object sender, EventArgs e)
        {
         menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
            }
        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            colores1 frm = new colores1();
            frm.Show();
            this.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("verde.wav");
            simpleSound.Play();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("blanco.wav");
            simpleSound.Play();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("rosado.wav");
            simpleSound.Play();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("rojo.wav");
            simpleSound.Play();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("negro.wav");
            simpleSound.Play();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("gris.wav");
            simpleSound.Play();
        }
    }
}
