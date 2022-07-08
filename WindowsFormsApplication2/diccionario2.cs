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
    public partial class diccionario2 : Form
    {
        public diccionario2()
        {
            InitializeComponent();
        }

        private void pictureBox3_CLick(object sender, EventArgs e)
        {
            menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox20_CLick(object sender, EventArgs e)
        {
            diccionario1 frm = new diccionario1();
            frm.Show();
            this.Visible = false;
        }
    }
}
