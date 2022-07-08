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
    public partial class puntos : Form
    {
        public puntos()
        {
            InitializeComponent();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("oriente.wav");
            simpleSound.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("norte.wav");
            simpleSound.Play();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("poniente.wav");
            simpleSound.Play();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("sur.wav");
            simpleSound.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }
    }
}
