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
    
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        OleDbConnection con1 = new OleDbConnection("provider=MSDAORA;Data Source=XE;User ID=baqer1;Password=qawsedrf;Unicode=True");
        private void FormShow_Load(object sender, EventArgs e)
        {
            con1.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("SELECT  nightshift.Doctor_ID,register.fullname,nightshift. Reservist_doctor, nightshift.shift_date FROM nightshift INNER JOIN register ON register.id = nightshift.Doctor_ID ", con1);
            DataTable dt1 = new DataTable();
            od.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con1.Close();
        }
    }
}
