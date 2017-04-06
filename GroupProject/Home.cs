using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        _ِAdvisory df = new _ِAdvisory();
        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.Show();
        }
        Registeration re = new Registeration();
        private void registerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
        night_shift n = new night_shift();
        private void determineShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
        FormShow fs = new FormShow();
       
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
          
        }

        private void detrmineShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.Show();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fs.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re.Show();
        }
        
        OleDbConnection con1 = new OleDbConnection("provider=MSDAORA;Data Source=XE;User ID=baqer1;Password=qawsedrf;Unicode=True");
        private void backUpDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup Files (*.Bak)|*.bak";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                con1.Open();
                OleDbCommand cmd = new OleDbCommand("Backup Database BAQER1 To Disk='" + sf.FileName + "'", con1);
                
                cmd.ExecuteNonQuery();
                con1.Close();
                
            }
            
        }
    }
}
