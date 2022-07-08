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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Width = 532;
            this.Height = 532;
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - this.Width;
            int y = boundHeight - this.Height;
            this.Location = new Point(x / 2, y / 2);
        }

 

        private void label1_Click(object sender, EventArgs e)
        {
            cuerpo frm = new cuerpo();
            frm.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            colores frm = new colores();
            frm.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
          numeros frm = new numeros();
            frm.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            animales frm = new animales();
            frm.Show();
            this.Visible = false;
        }
    }
}
