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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }
        Home f2 = new Home();
        
        String x = "admin", y = "admin";
        int i = 1;
        private void loginbu_Click(object sender, EventArgs e)
        {
            if (i <= 3)
              if (usertxt.Text == x && passtxt.Text == y)
                {

                    this.Hide();
                    f2.Show();
                    
                }
                else
                {
                   i++;
                    MessageBox.Show("Please, try again.");
                }
            else
               Close();
            

        }
    }
}
