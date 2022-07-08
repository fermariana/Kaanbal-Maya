using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox3.Image = Image.FromFile("inicio1.png");
          
             }
        private void popsonido()
        {
            string r;
            r = AppDomain.CurrentDomain.BaseDirectory;
            System.Media.SoundPlayer sonido;
            sonido = new System.Media.SoundPlayer(r + @"\pop.wav");
            sonido.Play();
        
           
          
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("inicio1.png");
            popsonido();
        }
       private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("inicio1.png");
        
        }

       private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
       {
           menu2 frm = new menu2();
           frm.Show();
           this.Visible = false;
       }

       private void label1_Click(object sender, EventArgs e)
       {
           Close();
       }

     

       
        

        
   

    }
}


