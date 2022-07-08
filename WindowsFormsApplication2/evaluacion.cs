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
    public partial class evaluacion : Form
    {
        public evaluacion()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

       

        private void label1_click(object sender, EventArgs e)
        {
            evaluacioncolores frm = new evaluacioncolores();
            frm.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            evaluacionanimales frm = new evaluacionanimales();
            frm.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cuerpo2 frm = new cuerpo2();
            frm.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            evaluacionfamilia frm = new evaluacionfamilia();
            frm.Show();
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            evaluacionpreguntas frm = new evaluacionpreguntas();
            frm.Show();
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            evaluacionfrutas frm = new evaluacionfrutas();
            frm.Show();
            this.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            evaluacionpuntos frm = new evaluacionpuntos();
            frm.Show();
            this.Visible = false;
        }
    }
}
