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
    public partial class cuerpo2 : Form
    {
        public cuerpo2()
        {
            InitializeComponent();
        }

        private void btncomprobar_Click(object sender, EventArgs e)
        {
              
                if (respuesta.Text == "koh" && respuesta1.Text == "lengua" && respuesta2.Text == "ich" && respuesta3.Text == "ook")
                {
                    DialogResult resul = MessageBox.Show("", "Felicidades has estudiado y aprendido el tema partes del cuerpo  ", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        evaluacion frm = new evaluacion();
                        frm.Show();
                        this.Visible = false;
                    }
                }




        }

        private void pintureBox11_click(object sender, EventArgs e)
        {
            evaluacion frm = new evaluacion();
            frm.Show();
            this.Visible = false;
        }
        }
    }

