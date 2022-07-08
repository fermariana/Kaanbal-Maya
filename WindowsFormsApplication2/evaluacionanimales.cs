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
    public partial class evaluacionanimales : Form
    {
        public evaluacionanimales()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {


            if (respuesta.Text == "taman" && respuesta1.Text == "gato" && respuesta2.Text == "koj" && respuesta3.Text == "pavo")
            {
                DialogResult resul = MessageBox.Show("", "Felicidades has estudiado y aprendido el tema animales  ", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    evaluacion frm = new evaluacion();
                    frm.Show();
                    this.Visible = false;
                }
            }




        }

        private void pictureBox11_click(object sender, EventArgs e)
        {
            evaluacion frm = new evaluacion();
            frm.Show();
            this.Visible = false;
        }
    }
}

