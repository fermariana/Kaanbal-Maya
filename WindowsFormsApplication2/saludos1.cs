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
    public partial class saludos1 : Form
    {
        public saludos1()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            saludos2  frm = new saludos2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
           saludos frm = new saludos();
            frm.Show();
            this.Visible = false;
        }
    }
}
