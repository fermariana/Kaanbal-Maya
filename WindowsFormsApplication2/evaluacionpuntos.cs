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
    public partial class evaluacionpuntos : Form
    {
        public evaluacionpuntos()
        {
            InitializeComponent();
        }

        private void btnComprobar_CLick(object sender, EventArgs e)
        {

            if (respuesta.Text == "sur" && respuesta1.Text == "norte" && respuesta2.Text == "este" && respuesta3.Text == "oeste")
            {
                DialogResult resul = MessageBox.Show("", "Felicidades has estudiado y aprendido el tema puntos cardinales  ", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    evaluacion frm = new evaluacion();
                    frm.Show();
                    this.Visible = false;
                }
            }




        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            evaluacion frm = new evaluacion();
            frm.Show();
            this.Visible = false;
        }
    }
}

