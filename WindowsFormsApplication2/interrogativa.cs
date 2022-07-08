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
    public partial class interrogativa : Form
    {
        public interrogativa()
        {
            InitializeComponent();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("quien.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("cuantos personas.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("cuantos objetos.wav");
            simpleSound.Play();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("cuantos plantas.wav");
            simpleSound.Play();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            interrogativas frm = new interrogativas();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }
    }
}
