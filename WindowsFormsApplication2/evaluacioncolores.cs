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
    public partial class evaluacioncolores : Form
    {
        public evaluacioncolores()
        {
            InitializeComponent();
        }

      

        private void btnComporbar_Click(object sender, EventArgs e)
        {
            if (respuesta.Text == "azul" && respuesta1.Text == "chak" && respuesta2.Text == "blanco" && respuesta3.Text == "cafe")
            {
                           DialogResult resul = MessageBox.Show("", "Felicidades has estudiado y aprendido el tema colores  ", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                evaluacion frm = new evaluacion();
                frm.Show();
                this.Visible = false;
            }
        }

            

          
        }

        private void pictureBox11_Clcik(object sender, EventArgs e)
        {
            evaluacion frm = new evaluacion();
            frm.Show();
            this.Visible = false;
        }
    }
}