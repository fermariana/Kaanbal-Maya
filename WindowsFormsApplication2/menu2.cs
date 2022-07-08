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
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            colores frm = new colores();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cuerpo frm = new cuerpo();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            numeros frm = new numeros();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           animales frm = new animales();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           puntos frm = new puntos();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            interrogativas frm = new interrogativas();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            alfabeto frm = new alfabeto();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frutas frm = new frutas();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            familia frm = new familia();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            evaluacion frm = new evaluacion();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox22_Clicl(object sender, EventArgs e)
        {
            frases frm = new frases();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            diccionario1 frm = new diccionario1();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pronombres frm = new pronombres();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox29_CLick(object sender, EventArgs e)
        {
            saludos frm = new saludos();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox30_Cick(object sender, EventArgs e)
        {
            prendas frm = new prendas();
            frm.Show();
            this.Visible = false;
        }
    }
}
