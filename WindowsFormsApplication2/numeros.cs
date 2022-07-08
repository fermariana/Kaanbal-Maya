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
    public partial class numeros : Form
    {
        public numeros()
        {
            InitializeComponent();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
            string r;
            r = AppDomain.CurrentDomain.BaseDirectory;
            axShockwaveFlash1.Movie = (r + @"\numbers.swf");
            axShockwaveFlash1.Play();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           menu2 frm = new menu2();
            frm.Show();
            this.Visible = false;
        }

        }
    }

