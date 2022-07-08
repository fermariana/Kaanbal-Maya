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
    public partial class cuerpo1 : Form
    {
        public cuerpo1()
        {
            InitializeComponent();
            pictureBox6.Image = Image.FromFile("labio.png");
            pictureBox8.Image = Image.FromFile("lengua.png");
            pictureBox10.Image = Image.FromFile("diente.png");
            pictureBox13.Image = Image.FromFile("nariz.png");
            pictureBox16.Image = Image.FromFile("frente.png");
            pictureBox18.Image = Image.FromFile("ojo.png");
            pictureBox19.Image = Image.FromFile("mejilla.png");

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
            pictureBox6.Image = Image.FromFile("labio1.png");
            SoundPlayer simpleSound = new SoundPlayer("labio2.wav");
            simpleSound.Play();

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("labio.png");
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("lengua1.png");
            SoundPlayer simpleSound = new SoundPlayer("lengua2.wav");
            simpleSound.Play();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("lengua.png");
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile("diente1.png");
            SoundPlayer simpleSound = new SoundPlayer("diente.wav");
            simpleSound.Play();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile("diente.png");
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile("nariz1.png");
            SoundPlayer simpleSound = new SoundPlayer("nariz2.wav");
            simpleSound.Play();
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile("nariz.png");
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("frente1.png");
            SoundPlayer simpleSound = new SoundPlayer("frente2.wav");
            simpleSound.Play();
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile("frente.png");
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile("ojo1.png");
            SoundPlayer simpleSound = new SoundPlayer("ojo2.wav");
            simpleSound.Play();
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile("ojo.png");
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile("mejilla1.png");
            SoundPlayer simpleSound = new SoundPlayer("mejilla2.wav");
            simpleSound.Play();
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile("mejilla.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           cuerpo frm = new cuerpo();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            cuerpo frm = new cuerpo();
            frm.Show();
        }

        }

    }
