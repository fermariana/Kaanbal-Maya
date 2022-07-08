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
    public partial class cuerpo : Form
    {
        public cuerpo()
        {
            InitializeComponent();
            pictureBox6.Image = Image.FromFile("cabello.png");
            pictureBox8.Image = Image.FromFile("hombro.png");
            pictureBox10.Image = Image.FromFile("mano.png");
            pictureBox12.Image = Image.FromFile("rodilla.png");
                pictureBox14.Image = Image.FromFile("pie.png");
                pictureBox16.Image = Image.FromFile("dedo de la mano.png");
                pictureBox18.Image = Image.FromFile("oreja.png");
                pictureBox20.Image = Image.FromFile("dedo del pie.png");
                pictureBox22.Image = Image.FromFile("pierna.png");
        
        
        }
        private void popsonido()
        {
            string r;
            r = AppDomain.CurrentDomain.BaseDirectory;
            System.Media.SoundPlayer sonido;
            sonido = new System.Media.SoundPlayer(r + @"\pop.wav");
            sonido.Play();



        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("cabello1.png");
            SoundPlayer simpleSound = new SoundPlayer("cabello2.wav");
            simpleSound.Play();

        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("cabello.png");

        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("hombro1.png");
            SoundPlayer simpleSound = new SoundPlayer("hombro2.wav");
            simpleSound.Play();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("hombro.png");
        
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile("mano1.png");
            SoundPlayer simpleSound = new SoundPlayer("mano2.wav");
            simpleSound.Play();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile("mano.png");
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile("rodilla1.png");
            SoundPlayer simpleSound = new SoundPlayer("rodilla2.wav");
            simpleSound.Play();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile("rodilla.png");
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile("pie1.png");
            SoundPlayer simpleSound = new SoundPlayer("pie2.wav");
            simpleSound.Play();
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile("pie.png");
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("dedo de la mano1.png");
            SoundPlayer simpleSound = new SoundPlayer("dedo de la mano2.wav");
            simpleSound.Play();
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("dedo de la mano.png");
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile("oreja1.png");
            SoundPlayer simpleSound = new SoundPlayer("oreja2.wav");
            simpleSound.Play();
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile("oreja.png");
        }

        private void pictureBox20_MouseHover(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile("dedo del pie1.png");
            SoundPlayer simpleSound = new SoundPlayer("dedo del pie2.wav");
            simpleSound.Play();
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile("dedo del pie.png");
        }

      

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile("pierna1.png");
            SoundPlayer simpleSound = new SoundPlayer("pierna2.wav");
            simpleSound.Play();
        }

        private void pictureBox22_MouseLevae(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile("pierna.png");
        }

        private void pictureBox23_MouseClick(object sender, MouseEventArgs e)
        {
            cuerpo1 frm = new cuerpo1();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu2 frm = new  menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            cuerpo1 frm = new cuerpo1();
            frm.Show();
            this.Visible = false;
        }

        

      






    }
}


