using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class _ِAdvisory : Form
    {
        public _ِAdvisory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        units un = new units();
        private void button1_Click(object sender, EventArgs e)
        {
            un.Show();
        }
    }
}
