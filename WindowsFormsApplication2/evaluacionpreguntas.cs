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
    public partial class evaluacionpreguntas : Form
    {
        public evaluacionpreguntas()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            if (respuesta.Text == "tu'ux" && respuesta1.Text == "máax" && respuesta2.Text == "ba'ax" && respuesta3.Text == "bix")
            {
                DialogResult resul = MessageBox.Show("", "Felicidades has estudiado y aprendido el tema formas interrogativas  ", MessageBoxButtons.YesNo);
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

